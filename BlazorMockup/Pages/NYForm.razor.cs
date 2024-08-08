using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace BlazorMockup.Pages
{
    public partial class NYForm
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        private bool IsOpen { get; set; } = false;
        private string SelectedValue { get; set; } = "Anden undersøgelse";

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
