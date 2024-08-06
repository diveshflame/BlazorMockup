using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public class DataStore
    {
        public List<Examination> Examinations { get; set; }

        public DataStore()
        {
            Examinations = new List<Examination>();

            // Add some sample data
            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-10),
                ExaminationType = "Type1",
                Weight = 70.5,
                HeadCircumference = 55.2,
                Height = 175.5,
                Note = "Sample note 1"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-5),
                ExaminationType = "Type2",
                Weight = 71.2,
                HeadCircumference = 56.1,
                Height = 176.3,
                Note = "Sample note 2"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Type3",
                Weight = 72.1,
                HeadCircumference = 57.5,
                Height = 177.2,
                Note = "Sample note 3"
            });
        }
    }
}
