using UnityEngine;
using Zenject;

public class ControllerInstaller : MonoInstaller<ControllerInstaller> {

    public override void InstallBindings() {
        Container.Bind<GridController>().FromNewComponentOnNewGameObject().AsCached();
        var playerPrefab = Resources.Load("Prefabs/Player");
        Container.Bind<PlayerController>().FromComponentInNewPrefab(playerPrefab).AsSingle();
        Container.Bind<InputController>().FromNewComponentOnNewGameObject().AsCached();
    }

}