using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace iSaveAs
{
    public class iSave
    {
        public string SaveAs(string fileName, ImageFormat targetFormat)
        {
            try
            {
                Image imageFile = null;
                string newFileName = GetTargetFileName(fileName, targetFormat);
                imageFile = Image.FromFile(fileName);
                imageFile.Save(newFileName, targetFormat);
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        
        public string GetTargetFileName(string sourceFileName, ImageFormat targetFormat)
        {
            int extIndex = sourceFileName.LastIndexOf(".");
            return sourceFileName.Substring(0, extIndex + 1) + GetFormatExtension(targetFormat);
        }


        private string GetFormatExtension(ImageFormat targetFormat)
        {
            if (targetFormat == ImageFormat.Jpeg)
                return "jpg";
            else if (targetFormat == ImageFormat.Png)
                return "png";
            else if (targetFormat == ImageFormat.Gif)
                return "gif";
            else if (targetFormat == ImageFormat.Bmp)
                return "bmp";
            else
                throw new ArgumentException("Requested format is not supported.  Please choose a different format.");
        }

    }
}
