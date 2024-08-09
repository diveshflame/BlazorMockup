using BlazorMockup.ViewModel;

namespace BlazorMockup.Pages
{
    public partial class Graphs
    {
        private GraphBase weightViewModel = new GraphBase
        {
            GraphType = "Weight"
        };

        private GraphBase heightViewModel = new GraphBase
        {
            GraphType = "Height"
        };

        protected override void OnInitialized()
        {
            ShowWeightGraph();
        }

        private void ShowWeightGraph()
        {
            weightViewModel.LoadMeasurementsFromDataStore(DataStore);
            StateHasChanged();
        }

        private void ShowHeightGraph()
        {
            heightViewModel.LoadMeasurementsFromDataStore(DataStore);
            StateHasChanged();
        }
    }
}
