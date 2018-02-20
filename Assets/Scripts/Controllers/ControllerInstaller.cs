using UnityEngine;
using Zenject;

public class ControllerInstaller : MonoInstaller<ControllerInstaller>
{
    public override void InstallBindings() {
        Container.Bind<GridController>().FromNewComponentOnNewGameObject().AsCached();
    }
}