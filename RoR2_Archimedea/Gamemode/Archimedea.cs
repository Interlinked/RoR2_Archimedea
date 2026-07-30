using System;
using R2API;
using GamemodeRun.Gamemode;
using R2API.Utils;
namespace RoR2_Archimedea.Gamemode {
    public static class ArchimedeaGamemode {
        public static GameObject ArchimedeaPrefab;
        public static void Create()
        {
            ArchimedeaPrefab = PrefabAPI.InstantiateClone(new("ArchimedeaRunObj"), "ArchimedeaRunObj");
            GameObject classic = Paths.GameObject.ClassicRun;

            ArchimedeaRun run = ArchimedeaPrefab.AddComponent<ArchimedeaRun>();
            run.lobbyBackgroundPrefab = classic.GetComponent<Run>().lobbyBackgroundPrefab;
            run.uiPrefab = classic.GetComponent<Run>().uiPrefab;
            run.userPickable = true;
            run.nameToken = "Archimedea";
            run.gameOverPrefab = classic.GetComponent<Run>().gameOverPrefab;
            run.startingSceneGroup = classic.GetComponent<Run>().startingSceneGroup;
            run.seed = classic.GetComponent<Run>().GenerateSeedForNewRun() / 2;
            UI.Init();
        }
    }

    
}