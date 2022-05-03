using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponseMod_AdvancedİnfinityEnergy
{
    public class Class1 : RocketPlugin<Config>
    {
        protected override void Load()
        {
            base.Load();
            UnturnedPlayerEvents.OnPlayerUpdateStamina += Energy;
        }

        private void Energy(UnturnedPlayer player, byte stamina)
        {
            if (!player.HasPermission(Configuration.Instance.VipPerm))
            {
                return;
            }

            if (stamina >= 50)
            {
                return;
            }

            player.Player.life.serverModifyStamina(100);
        }
    }
}
