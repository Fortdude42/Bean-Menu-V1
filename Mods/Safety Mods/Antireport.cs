using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using StupidTemplate.Notifications;
using UnityEngine;

namespace BeanMenuV1.Mods
{
    internal class AntiReport
    {
        public static void AntiReportmod()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    bool flag = gorillaPlayerScoreboardLine.linePlayer == NetworkSystem.Instance.LocalPlayer;
                    if (flag)
                    {
                        Transform transform = gorillaPlayerScoreboardLine.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            bool flag2 = vrrig != GorillaTagger.Instance.offlineVRRig;
                            if (flag2)
                            {
                                float num = Vector3.Distance(vrrig.rightHandTransform.position, transform.position);
                                float num2 = Vector3.Distance(vrrig.leftHandTransform.position, transform.position);
                                float num3 = 0.35f;
                                bool flag3 = num < num3 || num2 < num3;
                                if (flag3)
                                {
                                    PhotonNetwork.Disconnect();
                                    NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=grey>]</color> <color=white>Someone attempted to report you, you have been disconnected.</color>");
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}