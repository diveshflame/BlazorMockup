using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using BlazorMockup.Pages;
using BlazorMockup.Model;
using BlazorMockup.ViewModel;

namespace BlazorMockup.Pages
{
    public partial class NYForm
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Inject] private ExaminationEventService ExaminationEventService { get; set; }
        private bool IsOpen { get; set; } = false;
        private string SelectedValue { get; set; } = "Anden undersøgelse";
        private Examination newExamination = new Examination();
        public event EventHandler<Examination> ExaminationSaved;

        private ElementReference DateInput;
        private ElementReference WeightInput;
        private ElementReference HeightInput;
        private ElementReference InternNoteInput;

        private async Task SaveExamination()
        {
            var dateValue = await JSRuntime.InvokeAsync<string>("getElementValue", DateInput);
            if (!string.IsNullOrEmpty(dateValue))
            {
                newExamination.Date = DateTime.Parse(dateValue);
            }
            else
            {
                newExamination.Date = DateTime.MinValue;
            }

            newExamination.ExaminationType = SelectedValue;
            newExamination.Weight = float.Parse(await JSRuntime.InvokeAsync<string>("getElementValue", WeightInput));
            newExamination.Height = float.Parse(await JSRuntime.InvokeAsync<string>("getElementValue", HeightInput));
            newExamination.Note = await JSRuntime.InvokeAsync<string>("getElementValue", InternNoteInput);

            // Add the new examination to the DataStore
            //_dataStore.Examinations.Add(newExamination);
            await _dataStore.AddExaminationAsync(newExamination);
            ExaminationSaved?.Invoke(this, newExamination);

            ExaminationEventService.NotifyExaminationSaved();


            // Reset the form
            newExamination = new Examination();
            SelectedValue = "Anden undersøgelse";
            await JSRuntime.InvokeVoidAsync("setElementValue", DateInput, null);
            await JSRuntime.InvokeVoidAsync("setElementValue", WeightInput, null);
            await JSRuntime.InvokeVoidAsync("setElementValue", HeightInput, null);
            await JSRuntime.InvokeVoidAsync("setElementValue", InternNoteInput, null);

            // Close the dialog
            MudDialog.Close();
        }

        private void HandleClose()
        {
            MudDialog.Cancel();
        }


        private void ToggleDropdown()
        {
            IsOpen = !IsOpen;
        }

        private void SelectItem(string value)
        {
            SelectedValue = value;
            IsOpen = false;
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
            if (IsOpen)
            {
                IsOpen = false;
                StateHasChanged();
            }
        }

        private List<string> ExaminationTypes = new List<string>()
        {
        "Anden undersøgelse",
        "Fødsel",
        "5 uger",
        "5 måneder",
        "12 måneder",
        "2 år",
        "3 år",
        "4 år",
        };
    }
}
