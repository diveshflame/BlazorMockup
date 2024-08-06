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
                ExaminationType = "Week",
                Weight = 70.5,
                HeadCircumference = 55.2,
                Height = 175.5,
                Note = "Sample note 1"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-12),
                ExaminationType = "Month",
                Weight = 70.8,
                HeadCircumference = 55.8,
                Height = 175.8,
                Note = "Sample note 5"
            });
            
            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Quarter",
                Weight = 74.5,
                HeadCircumference = 59.5,
                Height = 180.5,
                Note = "Sample note 13"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-5),
                ExaminationType = "Week",
                Weight = 71.2,
                HeadCircumference = 56.1,
                Height = 176.3,
                Note = "Sample note 2"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Week",
                Weight = 72.1,
                HeadCircumference = 57.5,
                Height = 177.2,
                Note = "Sample note 3"
            });

              Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-15),
                ExaminationType = "Week",
                Weight = 69.8,
                HeadCircumference = 54.5,
                Height = 174.8,
                Note = "Sample note 4"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-8),
                ExaminationType = "Month",
                Weight = 71.5,
                HeadCircumference = 56.5,
                Height = 176.5,
                Note = "Sample note 6"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-3),
                ExaminationType = "Month",
                Weight = 72.3,
                HeadCircumference = 57.2,
                Height = 177.5,
                Note = "Sample note 7"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-2),
                ExaminationType = "Month",
                Weight = 72.8,
                HeadCircumference = 57.8,
                Height = 178.2,
                Note = "Sample note 8"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now.AddDays(-1),
                ExaminationType = "Year",
                Weight = 73.2,
                HeadCircumference = 58.2,
                Height = 178.5,
                Note = "Sample note 9"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Year",
                Weight = 73.5,
                HeadCircumference = 58.5,
                Height = 179.2,
                Note = "Sample note 10"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Year",
                Weight = 73.8,
                HeadCircumference = 58.8,
                Height = 179.5,
                Note = "Sample note 11"
            });

            Examinations.Add(new Examination
            {
                Date = DateTime.Now,
                ExaminationType = "Quarter",
                Weight = 74.2,
                HeadCircumference = 59.2,
                Height = 180.2,
                Note = "Sample note 12"
            });


        }
    }
}
