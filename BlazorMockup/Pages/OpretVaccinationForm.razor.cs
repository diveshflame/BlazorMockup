using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace BlazorMockup.Pages
{
    public partial class OpretVaccinationForm
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        private bool IsSearchVisible { get; set; } = false;
        private bool IsVaccineOpen { get; set; } = false;
        private string SelectedVaccine { get; set; } = " Vaccine 1";
        private bool IsDosageOpen { get; set; } = false;
        private string SelectedDosage { get; set; } = "5 ml";

        private void ToggleDropdown()
        {
            IsVaccineOpen = !IsVaccineOpen;
            IsSearchVisible = IsVaccineOpen;
        }

        private void SelectVaccine(string value)
        {
            SelectedVaccine = value;
            IsVaccineOpen = false;
            IsSearchVisible = false;
            StateHasChanged();
        }

        private void ToggleDosageDropdown()
        {
            IsDosageOpen = !IsDosageOpen;
        }

        private void SelectDosage(string value)
        {
            SelectedDosage = value;
            IsDosageOpen = false;
            StateHasChanged();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("addClickOutsideListener", DotNetObjectReference.Create(this));
            }
        }

        [JSInvokable]
        public void CloseDropdown()
        {
            if (IsVaccineOpen)
            {
                IsVaccineOpen = false;
                IsSearchVisible = false;
                StateHasChanged();
            }
            if (IsDosageOpen)
            {
                IsDosageOpen = false;
                StateHasChanged();
            }
        }

        private void HandleClose()
        {
            MudDialog.Cancel();
        }

        private List<string> Vaccines = new List<string>()
    {
        "Vaccine 1",
        "Vaccine 2",
        "Vaccine 3",
        "Vaccine 4",
        "Vaccine 5"
    };

        private List<string> Dosage = new List<string>()
    {
        "5 ml",
        "10 ml",
        "15 ml",
        "20 ml",
        "25 ml",
        "30 ml"
    };
    }
}
