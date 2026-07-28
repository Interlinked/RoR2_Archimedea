using BepInEx;
using RoR2;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Reflection;
using RoR2.UI;
using MonoMod.Cil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using RoR2_Archimedea.Gamemode;

namespace RoR2_Archimedea {
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class RoR2_Archimedea : BaseUnityPlugin {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "Interlink";
        public const string PluginName = "RoR2_Archimedea";
        public const string PluginVersion = "1.0.0";

        public static BepInEx.Logging.ManualLogSource ModLogger;
        public void Awake() {
            // set logger
            ModLogger = Logger;
            UI.Init();
            ConfigManager.HandleConfigAttributes(typeof(RoR2_Archimedea).Assembly, Config);
        }
        
    }
}