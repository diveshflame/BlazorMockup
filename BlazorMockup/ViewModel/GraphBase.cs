using BlazorMockup.DataWarehouse;
using BlazorMockup.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorMockup.ViewModel;

public class GraphBase : ComponentBase
{
    public string GraphType { get; set; } = "Weight";
    public List<Examination>? Measurements { get; private set; }
    public string LegendPosition { get; set; } = "right";

    public List<string> Labels => Measurements?.Select(m => m.Date.ToString("yyyy-MM-dd")).ToList() ?? new List<string>();

    public List<double> Data => GraphType switch
    {
        "Weight" => Measurements?.Select(m => m.Weight).ToList() ?? new List<double>(),
        _ => new List<double>()
    };

    public void LoadMeasurementsFromDataStore(IDataStore dataStore)
    {
        Measurements = dataStore.Examinations;
    }
}
