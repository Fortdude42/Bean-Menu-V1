using BeanMenuV1.Mods;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace Bean_Menu_V1.Mods
{
    internal class SettingsMods
    {

        public static void SafetyMods()
        {
            buttonsType = 1;
        }

        public static void MovmentMods()
        {
            buttonsType = 2;
        }


        public static void VisualMods()
        {
            buttonsType = 3;
        }

        public static void FunMods()
        {
            buttonsType = 4;
        }

        public static void RoomMods()
        {
            buttonsType = 5;
        }

        public static void OPMods()
        {
            buttonsType = 6;
        }

        public static void Setting()
        {
            buttonsType = 7;
        }

        public static void MenuSettings()
        {
            buttonsType = 8;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void righthanded()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectbutton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectbutton = false;
        }

    };
}
