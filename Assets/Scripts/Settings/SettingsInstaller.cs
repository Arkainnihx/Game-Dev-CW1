using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "SettingsInstaller", menuName = "Installers/SettingsInstaller")]
public class SettingsInstaller : ScriptableObjectInstaller<SettingsInstaller> {

    [SerializeField]
    PlayerMovementSettings playerMovementSettings;

    public override void InstallBindings() {
        Container.BindInstance(playerMovementSettings).AsCached();
        Container.QueueForInject(playerMovementSettings);
    }

}