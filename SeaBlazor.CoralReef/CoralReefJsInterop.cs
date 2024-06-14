using Microsoft.JSInterop;

namespace SeaBlazor.CoralReef
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class CoralReefJsInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public CoralReefJsInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async ValueTask<string> Prompt(string message)
        {
            return await _jsRuntime.InvokeAsync<string>("showPrompt", message);
        }

        public async Task CopyToClipBoard(string text)
        {
            await _jsRuntime.InvokeVoidAsync("copyToClipboard", text);
        }
    }
}
