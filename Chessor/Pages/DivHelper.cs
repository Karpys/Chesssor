using Chessor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public static class DivHelper
{
    public static async Task<Position> GetDivPosition(ElementReference elementRef)
    {
        return await JsService.Js.InvokeAsync<Position>("domHelper.getElementPositionRef", elementRef);
    }
}

public class JsService
{
    public static IJSRuntime Js { get; set; }

    public void SetJsService(IJSRuntime js)
    {
        Js = js;
    }
}