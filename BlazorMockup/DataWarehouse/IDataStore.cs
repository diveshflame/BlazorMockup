using BlazorMockup.Model;

namespace BlazorMockup.DataWarehouse
{
    public interface IDataStore
    {
        List<Examination> Examinations { get; set; }
        List<Vaccination> Vaccinations { get; set; }
    }
}