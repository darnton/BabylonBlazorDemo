using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class HemisphericLight : BabylonObject
    {
        public HemisphericLight(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
