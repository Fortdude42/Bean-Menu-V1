using System;
using System.Collections.Generic;
using System.Text;
using GorillaNetworking;
using Photon.Pun;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Visual_Mods
{
    internal class NoName
    {

        public static void noName()
        {
            PhotonNetwork.LocalPlayer.NickName = "";
            GorillaComputer.instance.currentName = "";
            GorillaComputer.instance.savedName = "";
            PlayerPrefs.SetString("GorillaLocomotion.PlayerName", "");
            PhotonNetwork.ReconnectAndRejoin();
        }
    }

}
