using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace imageToWeb {
    class Program {
        // context menu name in the registry
        const string KeyName = "OptWebImage";
        // context menu text
        const string MenuText = "Image->WEB800";
        const int maxSize = 800;

        static void Main(string[] args) {
            // process register or unregister commands
            if (!ProcessCommand(args)) {
                // invoked from shell, process the selected file
                DoOpt(args[0], maxSize);
            }
        }

        /// <summary>
        /// Process command line actions (register or unregister).
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>True if processed an action in the command line.</returns>
        static bool ProcessCommand(string[] args) {
            // register
            if (args.Length == 0 || string.Compare(args[0], "-register", true) == 0) {
                string iconPath = Application.CommonAppDataPath + Path.DirectorySeparatorChar + "MenuIcon.ico";
                // full path to self, %L is placeholder for selected file
                string menuCommand = string.Format("\"{0}\" \"%L\"", Application.ExecutablePath);
                // register the context menu
                if (FileShellExtension.Register(Program.KeyName, Program.MenuText, menuCommand, iconPath)) {
                    MessageBox.Show(string.Format("The {0} shell extension was registered.",
                        Program.KeyName), Program.KeyName);
                }
                return true;
            }
            // unregister		
            if (string.Compare(args[0], "-unregister", true) == 0) {
                // unregister the context menu
                if (FileShellExtension.Unregister(Program.KeyName)) {
                    MessageBox.Show(string.Format("The {0} shell extension was unregistered.",
                        Program.KeyName), Program.KeyName);
                }
                return true;
            }
            // command line did not contain an action
            return false;
        }

        private static void DoOpt(string args, int maxSize) {
            // Test if input arguments were supplied:
            if (args.Length == 0) {
                //System.Console.WriteLine("Please enter a numeric argument.");
                //System.Console.WriteLine("Usage: imageToWeb <image>");
                return;
            }
            // Try to convert the input arguments to numbers. This will throw
            // an exception if the argument is not a number.
            // num = int.Parse(args[0]);
            String imagePath;
            imagePath = args;
            //System.Console.WriteLine("Image Path: " + imagePath);
            if (File.Exists(imagePath)) {
                //System.Console.WriteLine("Image Path: " + imagePath + " ----> OK");
                var currentPath = Path.GetFullPath(imagePath);
                currentPath = Directory.GetParent(currentPath).FullName;
                //System.Console.WriteLine("Image currentPath: " + currentPath + " ----> OK");
                var fName = Path.GetFileName(imagePath);
                //System.Console.WriteLine("Image file name: " + fName + " ----> OK");
                var extension = Path.GetExtension(imagePath);
                //System.Console.WriteLine("Image file ext: " + extension + " ----> OK");
                var fNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
                //System.Console.WriteLine("Image file name without ext: " + fNameWithoutExtension + " ----> OK");
                var resized = ResizeImage(imagePath, maxSize, maxSize);
                extension = ".jpg";
                String newFilePath;
                //newFilePath  = currentPath + Path.DirectorySeparatorChar + fNameWithoutExtension + "_web90" + extension;
                //SaveWebImage(newFilePath, resized, 90);
                newFilePath = currentPath + Path.DirectorySeparatorChar + fNameWithoutExtension + "_web70" + extension;
                SaveWebImage(newFilePath, resized, 70);
                newFilePath = currentPath + Path.DirectorySeparatorChar + fNameWithoutExtension + "_web50" + extension;
                SaveWebImage(newFilePath, resized, 50);
                newFilePath = currentPath + Path.DirectorySeparatorChar + fNameWithoutExtension + "_web30" + extension;
                SaveWebImage(newFilePath, resized, 30);
                //newFilePath = currentPath + Path.DirectorySeparatorChar + fNameWithoutExtension + "_web10" + extension;
                //SaveWebImage(newFilePath, resized, 10);
                //} else {
                //    //System.Console.WriteLine("Image Path: " + imagePath + " ----> NOT OK");
                //}
                //return 0;
            }
        }

        private static ImageCodecInfo GetEncoderInfo(ImageFormat format) {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        /// <summary>
        /// A quick lookup for getting image encoders
        /// </summary>
        private static Dictionary<string, ImageCodecInfo> encoders = null;

        /// <summary>
        /// A lock to prevent concurrency issues loading the encoders.
        /// </summary>
        private static object encodersLock = new object();

        /// <summary>
        /// A quick lookup for getting image encoders
        /// </summary>
        public static Dictionary<string, ImageCodecInfo> Encoders {
            //get accessor that creates the dictionary on demand
            get {
                //if the quick lookup isn't initialised, initialise it
                if (encoders == null) {
                    //protect against concurrency issues
                    lock (encodersLock) {
                        //check again, we might not have been the first person to acquire the lock (see the double checked lock pattern)
                        if (encoders == null) {
                            encoders = new Dictionary<string, ImageCodecInfo>();
                            //get all the codecs
                            foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageEncoders()) {
                                //add each codec to the quick lookup
                                encoders.Add(codec.MimeType.ToLower(), codec);
                            }
                        }
                    }
                }
                //return the lookup
                return encoders;
            }
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(string filePath, int maxWidth, int maxHeight) {
            var image = System.Drawing.Image.FromFile(filePath);
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;
            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);
            int newWidth;
            int newHeight;
            if (ratio < 1) {
                // New width and height based on aspect ratio
                newWidth = (int)(originalWidth * ratio);
                newHeight = (int)(originalHeight * ratio);
            } else {
                newWidth = originalWidth;
                newHeight = originalHeight;
            }
            //a holder for the result
            Bitmap result = new Bitmap(newWidth, newHeight);
            //set the resolutions the same to avoid cropping due to resolution differences
            result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result)) {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }
            //return the resulting bitmap
            return result;
        }

        /// <summary> 
        /// Saves an image as a jpeg image, with the given quality 
        /// </summary> 
        /// <param name="path">Path to which the image would be saved.</param> 
        /// <param name="quality">An integer from 0 to 100, with 100 being the 
        /// highest quality</param> 
        /// <exception cref="ArgumentOutOfRangeException">
        /// An invalid value was entered for image quality.
        /// </exception>
        public static void SaveWebImage(string path, System.Drawing.Image image, int quality) {
            //ensure the quality is within the correct range
            if ((quality < 0) || (quality > 100)) {
                //create the error message
                string error = string.Format("Jpeg image quality must be between 0 and 100, with 100 being the highest quality.  A value of {0} was specified.", quality);
                //throw a helpful exception
                throw new ArgumentOutOfRangeException(error);
            }
            //create an encoder parameter for the image quality
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            //get the jpeg codec
            ImageCodecInfo jpegCodec = GetEncoderInfo0("image/jpeg");
            //create a collection of all parameters that we will pass to the encoder
            EncoderParameters encoderParams = new EncoderParameters(1);
            //set the quality parameter for the codec
            encoderParams.Param[0] = qualityParam;
            //save the image using the codec and the parameters
            image.Save(path, jpegCodec, encoderParams);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        public static ImageCodecInfo GetEncoderInfo0(string mimeType) {
            //do a case insensitive search for the mime type
            string lookupKey = mimeType.ToLower();
            //the codec to return, default to null
            ImageCodecInfo foundCodec = null;
            //if we have the encoder, get it to return
            if (Encoders.ContainsKey(lookupKey)) {
                //pull the codec from the lookup
                foundCodec = Encoders[lookupKey];
            }
            return foundCodec;
        }
    }

}

