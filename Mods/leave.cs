using System;
using System.Collections.Generic;
using System.Text;
using GorillaNetworking;
using Photon.Pun;
using StupidTemplate.Classes;

namespace Bean_Menu_V1.Mods
{
    internal class leave
    {
        public static void Leave()
        {
            PhotonNetwork.Disconnect();
        }
    }
}
