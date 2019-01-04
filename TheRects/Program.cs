using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Drawing;
using System.Text.RegularExpressions;

namespace TheRects
{
    static class Program
    {
        public static Game Game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new frmCalibrator());

            string[] args = Environment.GetCommandLineArgs();

            bool containDefaultScenarios = !args.Contains("-without_shapes");

            string iterationsArgument = args.FirstOrDefault(a => a.StartsWith("-iterations"));
            int iterations = 1;
            if(iterationsArgument!=null)
            {
                Match m = Regex.Match(iterationsArgument, @"=(?<iterations>\d+)");
                iterations = int.Parse(m.Groups["iterations"].Value);
            }

            string imagesArgument = args.FirstOrDefault(a => a.StartsWith("-source"));
            string imagesDirectory = "images";
            if(imagesArgument!=null)
            {
                Match m = Regex.Match(imagesArgument, @"=(?<name>\w+)");
                imagesDirectory = m.Groups["name"].Value;
            }

            Game = new Game(containDefaultScenarios, iterations, imagesDirectory);

            Application.Run(new frmIntro());
        }
    }
}
