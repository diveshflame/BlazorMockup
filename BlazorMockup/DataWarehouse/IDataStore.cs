using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public interface IDataStore
    {
        Task AddExaminationAsync(Examination examination);
        Task<IEnumerable<Examination>> GetExaminationsAsync();
    }
}