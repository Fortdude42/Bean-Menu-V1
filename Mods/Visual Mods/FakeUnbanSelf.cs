using System;
using System.Collections.Generic;
using System.Text;
using GorillaNetworking;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Visual_Mods
{
    internal class FakeUnbanSelf
    {
        public static void fakeUnbanSelf()
        {
            PhotonNetworkController.Instance.UpdateTriggerScreens();
            GorillaScoreboardTotalUpdater.instance.ClearOfflineFailureText();
            GorillaComputer.instance.screenText.DisableFailedState();
            GorillaComputer.instance.functionSelectText.DisableFailedState();
        }

        private static GameObject visualizerObject = null;
        private static GameObject visualizerOutline = null;
        public static void CreateAudioVisualizer()
        {
            visualizerObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            visualizerOutline = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            UnityEngine.Object.Destroy(visualizerObject.GetComponent<Collider>());
            UnityEngine.Object.Destroy(visualizerOutline.GetComponent<Collider>());
            UnityEngine.Object.Destroy(visualizerObject.GetComponent<Rigidbody>());
            UnityEngine.Object.Destroy(visualizerOutline.GetComponent<Rigidbody>());
        }

    }
}
