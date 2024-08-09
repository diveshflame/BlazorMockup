using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public interface IDataStore
    {
        Task AddExaminationAsync(Examination examination);
        Task AddVaccinationAsync(Vaccination vaccination);
        Task<IEnumerable<Examination>> GetExaminationsAsync();
        Task<IEnumerable<Vaccination>> GetVaccinationsAsync();
    }
}