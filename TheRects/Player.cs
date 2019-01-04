using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TheRects
{
    public enum RandomizeType
    {
        None, RandomizeScenarios, RandomizeGradeInfos
    }

    public class Player

    {
        public string Name;

        public int Age;

        public string Gender;


        public string Height { get; internal set; }
        public int Weight { get; internal set; }

        public int HandednessFlanders; //-10 to +10

        public int HandednessCoren; // -4 to +4
        public int FootednessCoren; //-4 to +4
        public int EyednessCoren; //-4 to +4
        public int EarednessCoren; //-4 to +4

        public int Bds; //1 to 9

        public override string ToString() => Name;

        public List<GradeInfo> Grades;

        public void InitializeGradeInfos(IEnumerable<Scenario> scenarios, RandomizeType randomizeType = RandomizeType.RandomizeScenarios)
        {
            switch (randomizeType)
            {
                case RandomizeType.None:
                    Grades = scenarios.SelectMany(s => s.GetDefaultGradeInfos()).ToList();
                    break;
                case RandomizeType.RandomizeGradeInfos:
                    //randomize ALL independently of the scenarios
                    Grades = scenarios.SelectMany(s => s.GetDefaultGradeInfos()).ToList();
                    Grades.Shuffle();
                    break;
                case RandomizeType.RandomizeScenarios:
                    List<Scenario> randomScenarios = scenarios.ToList();

                    int maxIterations = randomScenarios[0].Iterations;
                    Grades = new List<GradeInfo>();
                    //for each iteration randomize the scenarios
                    for (int iIteration = 0; iIteration < maxIterations; iIteration++)
                    {
                        randomScenarios.Shuffle();
                        //foreach iteration get the iIteration member only
                        Grades.AddRange(randomScenarios.Select(s => s.GetDefaultGradeInfos()[iIteration]));
                    }
                    break;
            }
        }

        public void SaveGradesToFile(string file, bool append)
        {
            bool fileExisted = File.Exists(file);
            using (StreamWriter writer = new StreamWriter(file, append, Encoding.Default))
            {
                //name, age gender, scenario_id, scenario_name, iteration, value
                if (!append || !fileExisted)
                    writer.WriteLine($"Name\tAge\tGender\tWeight [kg]\tHeight [m]\tScenario_ID\tScenario_Name\tIteration\tGrade\tTime [s]");

                foreach (GradeInfo info in Grades)
                    writer.WriteLine($"{Name}\t{Age}\t{Gender}\t{Weight}\t{Height}\t{info.Scenario.ID}\t{info.Scenario.Name}\t{info.Iteration}\t{info.Value:0.000}\t{info.Seconds:0.00}");
            }
        }

    }
}
