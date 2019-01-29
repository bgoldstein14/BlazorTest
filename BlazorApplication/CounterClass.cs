using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorApplication
{
    public class CounterClass : BlazorComponent
    {
        public int CurrentCount { get; set; }

        [Parameter]
        protected string SubTitle { get; set; }

        public void IncrementCount()
        {
            CurrentCount += 5;
        }
    }
}