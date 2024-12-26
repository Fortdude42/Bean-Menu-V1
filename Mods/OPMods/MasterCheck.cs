using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using StupidTemplate.Notifications;

namespace Bean_Menu_V1.Mods.OPMods
{
    internal class MasterCheck
    {
        public static void MasterCheckerMod()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>SUCCESS</color><color=grey>]</color> <color=white>You are master client.</color>");
            }
            else
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> <color=white>You are not master client.</color>");
            }
        }
    }
}

