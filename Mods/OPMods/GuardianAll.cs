using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using StupidTemplate.Notifications;

namespace Bean_Menu_V1.Mods.OPMods
{
    internal class GuardianAll
    {
        public static void guardianAll()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                int i = 0;
                foreach (GorillaGuardianZoneManager gorillaGuardianZoneManager in GorillaGuardianZoneManager.zoneManagers)
                {
                    if (gorillaGuardianZoneManager.enabled)
                    {
                        gorillaGuardianZoneManager.SetGuardian(PhotonNetwork.PlayerList[i]);
                        i++;
                    }
                }
            }
            else { NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>"); }
        }

    }
}
