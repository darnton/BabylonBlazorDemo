using Microsoft.JSInterop;

namespace BabylonBlazor.Babylon
{
    public class Scene : BabylonObject
    {
        public Scene(IJSRuntime jsRuntime, JsRuntimeObjectRef objRef) : base(jsRuntime, objRef) { }
    }
}
