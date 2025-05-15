using Microsoft.JSInterop;
public class ThemeService
{
    private readonly IJSRuntime _js;

    public ThemeService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task SetTheme(string theme)
    {
        await _js.InvokeVoidAsync("setThemeAttribute", theme);
    }
}
