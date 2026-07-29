using System;
using System.Collections;
using R2API.Utils;
using RoR2.UI;


namespace GamemodeRun.Gamemode
{
    public class ArchimedeaRun : Run
    {
       public override void Start()
        {
            base.seed = GenerateSeedForNewRun() / 2; 
            ModLogger.LogInfo($"ArchimedeaRun: Starting run with seed {base.seed}");
            base.Start();
        }
    }
}