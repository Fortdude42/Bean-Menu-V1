using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace Bean_Menu_V1.Mods.OPMods
{
    internal class GuardianSelf
    {
        public static void guardianSelf()
        {
            if (PhotonNetwork.IsMasterClient)
            {
                foreach (GorillaGuardianZoneManager gorillaGuardianZoneManager in GorillaGuardianZoneManager.zoneManagers)
                {
                    if (gorillaGuardianZoneManager.enabled)
                    {
                        gorillaGuardianZoneManager.SetGuardian(NetworkSystem.Instance.LocalPlayer);
                    }
                }
            }
        }
    }
}
