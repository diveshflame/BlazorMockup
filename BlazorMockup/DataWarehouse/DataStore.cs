using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public class DataStore : IDataStore
    {
        public List<Examination> Examinations { get; set; }
        public List<Vaccination> Vaccinations { get; set; }

        public DataStore()
        {
            Examinations = CreateExaminationsList();
            Vaccinations = CreateVaccinationList();
        }
        private List<Examination> CreateExaminationsList()
        {
            var examinations = new List<Examination>
            {
                new Examination { Date = new DateTime(2024, 1, 15), ExaminationType = "Routine", Weight = 10.5, HeadCircumference = 45.2, Height = 70.0, Note = "All normal" },
                new Examination { Date = new DateTime(2024, 2, 20), ExaminationType = "Growth", Weight = 11.0, HeadCircumference = 45.5, Height = 72.0, Note = "Slightly above average height" },
                new Examination { Date = new DateTime(2024, 3, 12), ExaminationType = "Routine", Weight = 11.5, HeadCircumference = 46.0, Height = 74.0, Note = "Healthy growth" },
                new Examination { Date = new DateTime(2024, 4, 25), ExaminationType = "Growth", Weight = 12.0, HeadCircumference = 46.5, Height = 76.0, Note = "Normal" },
                new Examination { Date = new DateTime(2024, 5, 10), ExaminationType = "Routine", Weight = 12.5, HeadCircumference = 47.0, Height = 78.0, Note = "All normal" },
                new Examination { Date = new DateTime(2024, 6, 15), ExaminationType = "Growth", Weight = 13.0, HeadCircumference = 47.5, Height = 80.0, Note = "Healthy growth" },
                new Examination { Date = new DateTime(2024, 7, 20), ExaminationType = "Routine", Weight = 13.5, HeadCircumference = 48.0, Height = 82.0, Note = "Normal development" },
                new Examination { Date = new DateTime(2024, 8, 10), ExaminationType = "Growth", Weight = 14.0, HeadCircumference = 48.5, Height = 84.0, Note = "All normal" },
                new Examination { Date = new DateTime(2024, 9, 25), ExaminationType = "Routine", Weight = 14.5, HeadCircumference = 49.0, Height = 86.0, Note = "Healthy" },
                new Examination { Date = new DateTime(2024, 10, 30), ExaminationType = "Growth", Weight = 15.0, HeadCircumference = 49.5, Height = 88.0, Note = "Normal growth" }
            };
            return examinations;

        }

        private List<Vaccination> CreateVaccinationList()
        {
            var vaccinations = new List<Vaccination>
            {
                new Vaccination { Date = new DateTime(2024, 1, 10), Vaccine = "MMR", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "4" },
                new Vaccination { Date = new DateTime(2024, 2, 15), Vaccine = "Polio", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "5" },
                new Vaccination { Date = new DateTime(2024, 3, 5), Vaccine = "DTP", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "3" },
                new Vaccination { Date = new DateTime(2024, 4, 20), Vaccine = "Hepatitis B", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "2" },
                new Vaccination { Date = new DateTime(2024, 5, 10), Vaccine = "Varicella", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "5" },
                new Vaccination { Date = new DateTime(2024, 6, 15), Vaccine = "Pneumococcal", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "4" },
                new Vaccination { Date = new DateTime(2024, 7, 10), Vaccine = "Rotavirus", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "3" },
                new Vaccination { Date = new DateTime(2024, 8, 25), Vaccine = "Hib", Dosage = "2mg", Duration = "1 year", Note = "Routine vaccination", Credibility = "4" },
                new Vaccination { Date = new DateTime(2024, 9, 15), Vaccine = "Influenza", Dosage = "2mg", Duration = "1 year", Note = "Seasonal flu vaccine", Credibility = "3" },
                new Vaccination { Date = new DateTime(2024, 10, 5), Vaccine = "COVID-19", Dosage = "2mg", Duration = "1 year", Note = "Annual booster", Credibility = "5" }
            };
            return vaccinations;
        }
    }
}
