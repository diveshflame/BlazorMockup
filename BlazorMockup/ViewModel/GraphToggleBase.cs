using Microsoft.AspNetCore.Components;

namespace BlazorMockup;

public class GraphToggleBase :ComponentBase
{
    public bool isGridActive = true;

        [Parameter] public EventCallback<bool> OnToggleChanged { get; set; }

        public string GridClass => isGridActive ? "bg-[#32947C] text-white" : "bg-white text-black";
        public string GraphClass => isGridActive ? "bg-white text-black" : "bg-[#32947C] text-white";

        public async Task ToggleGrid()
        {
            isGridActive = true;
            await OnToggleChanged.InvokeAsync(isGridActive);
        }

        public async Task ToggleGraph()
        {
            isGridActive = false;
            await OnToggleChanged.InvokeAsync(isGridActive);
        }

}
