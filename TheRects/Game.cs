using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

using static TheRects.PathExtensions;

namespace TheRects
{
    public class Game
    {
        public Game(bool addDefaultScenarios, int iterations, string subDirectory)
        {
            if (addDefaultScenarios)
                AddDefaultScenarios(iterations);

            // LoadScenariosFromFile();

            AddImageScenariosFromDirectory(iterations, subDirectory);

            AddDoubleImageScenariosFromDirectory(iterations, subDirectory);

        }

        public Player Player;
        public List<Scenario> Scenarios = new List<Scenario>();

        public void AddImageScenariosFromDirectory(int iterations, string subDirectory)
        {
            //load all png files sorted by filename
            string[] files = Directory.GetFiles(CombineWithExecutableDirectory(subDirectory), "*.png").OrderBy(f => f).ToArray();

            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (Regex.IsMatch(fileName, @"\w+-\d")) continue;

                bool createOppositeToo = fileName.Contains("user");
                if (createOppositeToo) //add an additional scenario
                    Scenarios.Add(new Scenario(fileName, Scenarios.Count, iterations, fileName, Image.FromFile(file), true));

                Scenarios.Add(new Scenario(fileName, Scenarios.Count, iterations, fileName, Image.FromFile(file), false));

            }
        }
        public void AddDoubleImageScenariosFromDirectory(int iterations, string subDirectory)
        {
            //load all png files sorted by filename
            string[] files = Directory.GetFiles(CombineWithExecutableDirectory(subDirectory), "*.png").OrderBy(f => f).ToArray();

            foreach (string file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (!Regex.IsMatch(fileName, @"\w+-1")) continue;

                Match m = Regex.Match(fileName, @"(?<base>\w+)-1");
                string @base = m.Groups["base"].Value;
                string pairFile = Path.Combine(Path.GetDirectoryName(file), @base + "-2.png");

                Scenarios.Add(new Scenario(@base, Scenarios.Count, iterations, @base, Image.FromFile(file), Image.FromFile(pairFile)));
            }
        }

        public void AddDefaultScenarios(int iterations)
        {
            Scenarios.Add(new Scenario("empty", Scenarios.Count, iterations, "empty", ScenarioType.Empty));

            Scenarios.Add(new Scenario("same_squares", Scenarios.Count, iterations, "same_squares", ScenarioType.SameSquares));
            Scenarios.Add(new Scenario("squares_small_large", Scenarios.Count, iterations, "squares_small_large", ScenarioType.SquaresSmallLarge));
            Scenarios.Add(new Scenario("squares_large_small", Scenarios.Count, iterations, "squares_large_small", ScenarioType.SquaresLargeSmall));
            Scenarios.Add(new Scenario("same_circles", Scenarios.Count, iterations, "same_circles", ScenarioType.SameCircles));
            Scenarios.Add(new Scenario("circles_small_large", Scenarios.Count, iterations, "circles_small_large", ScenarioType.CirclesSmallLarge));
            Scenarios.Add(new Scenario("circles_large_small", Scenarios.Count, iterations, "circles_large_small", ScenarioType.CirclesLargeSmall));

            Scenarios.Add(new Scenario("same_thin_rectangle", Scenarios.Count, iterations, "same_thin_rectangle", ScenarioType.SameThinRectangle));
            Scenarios.Add(new Scenario("same_thick_rectangle", Scenarios.Count, iterations, "same_thick_rectangle", ScenarioType.SameThickRectangle));
            Scenarios.Add(new Scenario("rectangles_thin_thick", Scenarios.Count, iterations, "rectangles_thin_thick", ScenarioType.ThinThickRectangle));
            Scenarios.Add(new Scenario("rectangles_thick_thin", Scenarios.Count, iterations, "rectangles_thick_thin", ScenarioType.ThickThinRectangle));
        }
    }
}
