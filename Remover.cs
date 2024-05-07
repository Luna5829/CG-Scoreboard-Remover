using BepInEx;

using UnityEngine;

namespace CGSR
{
    [BepInPlugin("CGSR", "CGSR", "1.0.0")]
    public class Remover : BaseUnityPlugin
    {
        void Update()
        {
            if (SceneHelper.CurrentScene == "Endless")
            {
                GameObject Panel = GameObject.Find("Everything/Cube/Canvas");

                if (Panel == null)
                {
                    return;
                }

                if (Panel.activeSelf == true)
                {
                    Panel.gameObject.SetActive(false);
                    Logger.LogInfo("Disabled Scoreboard.");
                }
            }
        }
    }
}
