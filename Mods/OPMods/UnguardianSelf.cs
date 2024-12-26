using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using StupidTemplate.Notifications;

namespace Bean_Menu_V1.Mods.OPMods
{
    internal class UnguardianSelf
    {
        public static void unguardianSelf()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                foreach (GorillaGuardianZoneManager gorillaGuardianZoneManager in GorillaGuardianZoneManager.zoneManagers)
                {
                    if (gorillaGuardianZoneManager.enabled)
                    {
                        if (gorillaGuardianZoneManager.CurrentGuardian == NetworkSystem.Instance.LocalPlayer)
                        {
                            gorillaGuardianZoneManager.SetGuardian(null);
                        }
                    }
                }
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

    }
}
