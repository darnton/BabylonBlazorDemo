using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class PointLight : BabylonObject
    {
        public PointLight(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
