using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using BepInEx;
using ExitGames.Client.Photon.StructWrapping;
using UnityEngine;
using UnityEngine.UI;

namespace StupidTemplate.Mods
{
    internal class ghostMonkeAndInvis
    {
        public static bool toggleGhostInvis;
        private static bool ghostToggled;
        private static bool invisToggled;
        public static void GhostMonke()
        {
            bool rp = ControllerInputPoller.instance.rightControllerPrimaryButton || UnityInput.Current.GetMouseButton(0);
            if (toggleGhostInvis)
            {
                if (rp)
                {
                    if (!ghostToggled && GorillaTagger.Instance.offlineVRRig.enabled)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        ghostToggled = true;
                        return;
                    }
                    if (!ghostToggled && !GorillaTagger.Instance.offlineVRRig.enabled)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        ghostToggled = true;
                        return;
                    }
                }
                else ghostToggled = false;
                return;
            }
            GorillaTagger.Instance.offlineVRRig.enabled = !rp;
        }
        public static void InvisMonke()
        {
            bool rp = ControllerInputPoller.instance.rightControllerPrimaryButton || UnityInput.Current.GetMouseButton(0);
            if (toggleGhostInvis)
            {
                if (rp)
                {
                    if (!invisToggled && GorillaTagger.Instance.offlineVRRig.enabled)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = new UnityEngine.Vector3(GorillaTagger.Instance.offlineVRRig.transform.position.x, -100, GorillaTagger.Instance.offlineVRRig.transform.position.z);
                        invisToggled = true;
                        return;
                    }
                    if (!invisToggled && !GorillaTagger.Instance.offlineVRRig.enabled)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        invisToggled = true;
                        return;
                    }
                }
                else invisToggled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.transform.position = rp ? new UnityEngine.Vector3(GorillaTagger.Instance.offlineVRRig.transform.position.x, -100, GorillaTagger.Instance.offlineVRRig.transform.position.z) : UnityEngine.Vector3.zero;
                GorillaTagger.Instance.offlineVRRig.enabled = !rp;
            }
        }
    }
}
