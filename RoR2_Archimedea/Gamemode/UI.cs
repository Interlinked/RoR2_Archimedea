using System;
using RoR2.UI;
using UnityEngine.SceneManagement;

namespace RoR2_Archimedea.Gamemode {
    public static class UI {
        public static void Init()
        {
            "ARCHIMEDEA_MENU_NAME".Add("Archimedea");
            "ARCHIMEDEA_HOVERDESC".Add("Play a unique, difficult run with a random survivor and random modifiers.");

            SceneManager.activeSceneChanged += OnSceneChanged;
            On.RoR2.ConsoleFunctions.SubmitCmd += (orig, self, cmd) =>
            {
                if(self.GetComponent<HGButton>() && self.GetComponent<HGButton>().hoverToken == "ARCHIMEDEA_HOVERDESC")
                {
                    if(cmd == "transition_command \"gamemode Archimedea; host 0;\"")
                    {
                       orig(self,cmd);

                    }
                } else
                {
                    orig(self,cmd);
                }
            };
        }
        public static void OnSceneChanged(Scene prev, Scene next)
        {
            if (next.name == "title")
            {
                GameObject menu = GameObject.Find("MainMenu");
                Transform buttonTransform = menu.transform.Find("MENU: Extra Game Mode/ExtraGameModeMenu/Main Panel/GenericMenuButtonPanel/JuicePanel/GenericMenuButton (Eclipse)");
                if (buttonTransform)
                {
                    GameObject button = UnityEngine.Object.Instantiate(buttonTransform.gameObject, buttonTransform.parent);
                    button.GetComponent<LanguageTextMeshController>().token = "ARCHIMEDEA_MENU_NAME";
                    ConsoleFunctions consoleFunctions = button.GetComponent<ConsoleFunctions>();
                    HGButton component = button.GetComponent<HGButton>();
                    component.hoverToken = "ARCHIMEDEA_HOVERDESC";
                    component.onClick.RemoveAllListeners();
                    component.onClick.AddListener(delegate
                    {
                        consoleFunctions.SubmitCmd("transition_command \"gamemode Archimedea; host 0;\"");
                    });
               
                }  else
                {
                    Debug.LogError("Could not find transform");
                }         
            }
        }
}       
}