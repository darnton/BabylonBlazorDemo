using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class Vector3 : BabylonObject
    {
        public Vector3(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
