using System.Dynamic;
using System.Threading.Tasks;

namespace BabylonBlazor.Babylon
{
    public interface IBabylonFactory
    {
        Task<ArcRotateCamera> CreateArcRotateCamera(string name, double alpha, double beta, double radius, Vector3 target, Scene scene, string canvasId);
        Task<Engine> CreateEngine(string canvasId, bool antialias = false);
        Task<HemisphericLight> CreateHemispehericLight(string name, Vector3 direction, Scene scene);
        Task<PointLight> CreatePointLight(string name, Vector3 direction, Scene scene);
        Task<Scene> CreateScene(Engine engine);
        Task<Mesh> CreateSphere(string name, ExpandoObject options, Scene scene);
        Task<Vector3> CreateVector3(double x, double y, double z);
    }
}