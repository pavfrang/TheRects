using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;

namespace TheRects
{
    public static class PathExtensions
    {

        public static string CombineWithExecutableDirectory(params string[] components)
        {
            string basePath = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(new string[] { basePath }.Concat(components).ToArray());
        }
    }
}
