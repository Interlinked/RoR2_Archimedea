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
            
        }
       
}
}