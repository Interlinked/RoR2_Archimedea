using System;
using System.Collections;
using R2API.Utils;
using RoR2.UI;


namespace RoR2_Archimedea.Gamemode
{
    public class ArchimedeaRun : Run
    {
       public override void Start()
        {
            ModLogger.LogInfo("Archimedea run started");
            base.Start();
        }
    }
}