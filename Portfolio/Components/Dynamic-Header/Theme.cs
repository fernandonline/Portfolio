using Microsoft.JSInterop;

namespace Portfolio.Components.DynamicHeader
{
    public class ThemeService(IJSRuntime js)
    {
        private readonly IJSRuntime _js = js;

        public async Task SetTheme(string theme)
        {
            await _js.InvokeVoidAsync("setThemeAttribute", theme);
        }
    }
}