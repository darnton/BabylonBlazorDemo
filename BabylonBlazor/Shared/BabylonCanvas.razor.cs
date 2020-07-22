using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using BabylonBlazor.Babylon;
using System;
using System.Dynamic;
using System.Collections.Generic;

namespace BabylonBlazor.Shared
{
    public class BabylonCanvasBase : ComponentBase
    {
        //[Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] IBabylonFactory Babylon { get; set; }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);

            if (firstRender)
            {
                //await JsRuntime.InvokeVoidAsync("babylonInterop.initCanvas", "babylon-canvas");

                var canvasId = "babylon-canvas";
                var engine = await Babylon.CreateEngine(canvasId, true);
                var scene = await Babylon.CreateScene(engine);
                var cameraTarget = await Babylon.CreateVector3(0, 0, 5);
                var camera = await Babylon.CreateArcRotateCamera("Camera", Math.PI / 2, Math.PI / 2, 2, cameraTarget, scene, canvasId);
                var hemisphericLightDirection = await Babylon.CreateVector3(1, 1, 0);
                var light1 = await Babylon.CreateHemispehericLight("light1", hemisphericLightDirection, scene);
                var pointLightDirection = await Babylon.CreateVector3(0, 1, -1);
                var light2 = await Babylon.CreatePointLight("light2", pointLightDirection, scene);
                var sphereOptions = new ExpandoObject();
                sphereOptions.TryAdd("diameter", 2);
                var sphere = await Babylon.CreateSphere("sphere", sphereOptions, scene);
                await engine.RunRenderLoop(scene);
            }
        }
    }
}
