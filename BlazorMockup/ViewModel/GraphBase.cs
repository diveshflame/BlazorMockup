using BlazorMockup.DataWarehouse;
using BlazorMockup.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorMockup.ViewModel;

public class GraphBase : ComponentBase
{
    public string GraphType { get; set; } = "Weight";
    public List<Examination>? Measurements { get; private set; }
    public string LegendPosition { get; set; } = "right";

    public List<string> Labels => Measurements?.Select(m => m.Date.ToString("MMM")).ToList() ?? new List<string>();


    public List<double> Data => GraphType switch
    {
        "Weight" => Measurements?.Select(m => m.Weight).ToList() ?? new List<double>(),
        "Height" => Measurements?.Select(m => m.Height).ToList() ?? new List<double>(),
        _ => new List<double>()
    };

      // Standard deviation lines
        public List<double> LinePlusTwo => Data.Select(d => d + 2).ToList();
        public List<double> LinePlusOne => Data.Select(d => d + 1).ToList();
        public List<double> LineMinusOne => Data.Select(d => d - 1).ToList();
        public List<double> LineMinusTwo => Data.Select(d => d - 2).ToList();

    public void LoadMeasurementsFromDataStore(IDataStore dataStore)
    {
        Measurements = dataStore.GetExaminationsAsync().Result.ToList();
    }

}
