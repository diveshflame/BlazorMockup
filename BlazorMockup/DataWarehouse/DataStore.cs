using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public class DataStore : IDataStore
    {
        public List<Examination> Examinations;
        public List<Vaccination> Vaccinations;
        public DataStore()
        {
            Examinations = CreateExaminationsList();
            Vaccinations = CreateVaccinationList();
        }
        private List<Examination> CreateExaminationsList()
        {
            var examinations = new List<Examination>
            {

            };
            return examinations;

        }

        private List<Vaccination> CreateVaccinationList()
        {
            var vaccinations = new List<Vaccination>
            {
new Vaccination { Date = new DateTime(2024, 1, 10), Vaccine = "MMR", Dosage = "2mg", Varighed = "1 year", Note = "Routine vaccination", Credibility = "4" },
new Vaccination { Date = new DateTime(2024, 2, 15), Vaccine = "Polio", Dosage = "2mg", Varighed = "1 year", Note = "Routine vaccination", Credibility = "5" },
new Vaccination { Date = new DateTime(2024, 3, 5), Vaccine = "DTP", Dosage = "2mg", Varighed = "1 year", Note = "Routine vaccination", Credibility = "3" },
new Vaccination { Date = new DateTime(2024, 4, 20), Vaccine = "Hepatitis B", Dosage = "2mg", Varighed = "1 year", Note = "Routine vaccination", Credibility = "2" },
            };
            return vaccinations;
        }
        public async Task AddExaminationAsync(Examination examination)
        {
            Examinations.Add(examination);
        }
        public async Task<IEnumerable<Examination>> GetExaminationsAsync()
        {
            return Examinations;
        }

        public async Task AddVaccinationAsync(Vaccination vaccination)
        {
            Vaccinations.Add(vaccination);
        }
        public async Task<IEnumerable<Vaccination>> GetVaccinationsAsync()
        {
            return Vaccinations;
        }
    }
}
