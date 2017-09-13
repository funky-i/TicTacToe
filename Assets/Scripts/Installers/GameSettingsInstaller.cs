using UnityEngine;
using Zenject;

//[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller> {
    public GameInstaller.Settings GameInstaller;
    public PopupManager.Settings PopupManagerSettings;


    public override void InstallBindings() {
        Container.BindInstance(GameInstaller);
        Container.BindInstance(PopupManagerSettings);
    }
}