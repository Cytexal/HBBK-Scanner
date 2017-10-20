﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBBK_Scanner
{
    class ImageUtils
    {
        public static List<String> getImagesinFolder(String path)
        {
            List<String> imagepaths = new List<string>();
            imagepaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.png", System.IO.SearchOption.AllDirectories).ToList());
            imagepaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.jpg", System.IO.SearchOption.AllDirectories).ToList());
            imagepaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.jpeg", System.IO.SearchOption.AllDirectories).ToList());
            imagepaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.gif", System.IO.SearchOption.AllDirectories).ToList());
            return imagepaths;
        }

        

        public static String getImageName(String path)
        {
            List<Char> chars = path.ToList();
            Char actuall = '#';
            int pos = path.Length - 1;
            String imagename = "";
            while (actuall != '\\')
            {
                actuall = path[pos];
                pos -= 1;

            }
            for (int i = pos + 2; i < path.Length; i++)
            {
                imagename = imagename + path[i];
            }
            return imagename;

        }
    }
}
