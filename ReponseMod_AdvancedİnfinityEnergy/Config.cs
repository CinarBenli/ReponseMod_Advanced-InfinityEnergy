using Rocket.API;

namespace ReponseMod_AdvancedİnfinityEnergy
{
    public class Config : IRocketPluginConfiguration
    {
        public string VipPerm;
        public void LoadDefaults()
        {
            VipPerm = "Vip";
        }
    }
}