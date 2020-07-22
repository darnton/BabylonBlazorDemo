using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class Mesh : BabylonObject
    {
        public Mesh(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
