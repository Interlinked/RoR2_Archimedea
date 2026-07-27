using BepInEx.Configuration;
using RoR2_Archimedea.Utils;

namespace RoR2_Archimedea.Utils
{
    public class ConfigOption<T>
    {
        private ConfigEntry<T> Bind;

        public ConfigOption(ConfigFile config, string categoryName, string configOptionName, T defaultValue, string fullDescription)
        {
            Bind = config.Bind<T>(categoryName, configOptionName, defaultValue, fullDescription);
        }

        public static implicit operator T(ConfigOption<T> x)
        {
            return x.Bind.Value;
        }

        public override string ToString()
        {
            return Bind.Value.ToString();
        }
    }
}