using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class ArcRotateCamera : BabylonObject
    {
        public ArcRotateCamera(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
