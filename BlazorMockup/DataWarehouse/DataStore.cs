using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public class DataStore
    {
        public List<Examination> Examinations { get; set; }

        public DataStore()
        {
            Examinations = CreateExaminations();
        }

        private List<Examination> CreateExaminations()
        {
            var examinations = new List<Examination>();

            // Generate examination types
            var examinationTypes = new[] { "Week", "Month", "Quarter", "Year" };
            var dates = Enumerable.Range(0, 16).Select(i => DateTime.Now.AddDays(-10 * (i + 1))).ToArray();
            var weights = GenerateValues(16, 70.0, 77.5, 1.3);
            var headCircumferences = GenerateValues(16, 55.0, 62.5, 1.3);
            var heights = GenerateValues(16, 175.0, 183.5, 1.3);
            var notes = Enumerable.Range(1, 16).Select(i => $"Sample note {i}").ToArray();

            for (int i = 0; i < examinationTypes.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    examinations.Add(new Examination
                    {
                        Date = dates[i * 4 + j],
                        ExaminationType = examinationTypes[j],
                        Weight = weights[i * 4 + j],
                        HeadCircumference = headCircumferences[i * 4 + j],
                        Height = heights[i * 4 + j],
                        Note = notes[i * 4 + j]
                    });
                }
            }

            return examinations;
        }

        private double[] GenerateValues(int count, double start, double end, double increment)
        {
            return Enumerable.Range(0, count).Select(i => start + i * increment).ToArray();
        }

    }
}
