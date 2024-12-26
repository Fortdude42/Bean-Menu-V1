using Bean_Menu_V1.Mods;
using Bean_Menu_V1.Mods.Fun_Mods;
using Bean_Menu_V1.Mods.Movement_Mods;
using Bean_Menu_V1.Mods.OPMods;
using Bean_Menu_V1.Mods.RoomMods;
using Bean_Menu_V1.Mods.Safety_Mods;
using Bean_Menu_V1.Mods.Visual_Mods;
using BeanMenuV1.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {


            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Safety", method =() => SettingsMods.SafetyMods(), isTogglable = false},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovmentMods(), isTogglable = false},
                new ButtonInfo { buttonText = "Visual", method =() => SettingsMods.VisualMods(), isTogglable = false},
                new ButtonInfo { buttonText = "Fun", method =() => SettingsMods.FunMods(), isTogglable = false},
                new ButtonInfo { buttonText = "Room", method =() => SettingsMods.RoomMods(), isTogglable = false},
                new ButtonInfo { buttonText = "OP", method =() => SettingsMods.OPMods(), isTogglable = false},
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.Setting(), isTogglable = false},
            },
             new ButtonInfo[] { // Safety Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "Anti Report", method = () => AntiReport.AntiReportmod(), toolTip = "Description" },
                new ButtonInfo { buttonText = "No Finger Movement", method =() => NoFingerMovement.NoFinger(), toolTip = "Makes your fingers have no movement" },
            },
            new ButtonInfo[] { // Movement Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "SpeedBoost", method = () => SpeedBoost.SpeedBoostmod(), toolTip = "Gives you a speed boost" },
                new ButtonInfo { buttonText = "Faster SpeedBoost", method =() => FastSpeedBoost.fastSpeedBoost(), toolTip = "Gives more speed then the normal speedboost" },
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.Plats(), toolTip = "Makes platforms with grips" },
                new ButtonInfo { buttonText = "Trigger platforms", method =() => Triggerplatforms.Plats(), toolTip = "Makes platforms with triggers" },
                new ButtonInfo { buttonText = "NoClip (RT)", method = () => Noclip.noClip(), toolTip = "Makes everything have no collidrs" },
                new ButtonInfo { buttonText = "Fly (A)", method = () => Flymod.Fly(), toolTip = "gives you fight" },
                new ButtonInfo { buttonText = "RightGripFly", method = () => RightGripFly.GripFly(), toolTip = "gives you fight with grip" },
                new ButtonInfo { buttonText = "TriggerFly", method = () => TriggerFLy.triggerFly(), toolTip = "gives you fight with triggers" },
                new ButtonInfo { buttonText = "Fast Fly", method = () => Fastfly.fastFly(), toolTip = "Fast fly" },
                new ButtonInfo { buttonText = "Ghost Monke (A)", method = () => ghostMonkeAndInvis.GhostMonke(), toolTip = "Gives you ghost" },
                new ButtonInfo { buttonText = "Invis Monke (A)", method =() => ghostMonkeAndInvis.InvisMonke(), toolTip = "Makes you invis" },
                new ButtonInfo { buttonText = "SteamLongArms", method =() => SteamLongArms.steamLongArms(), toolTip = "Gives you LongArms" },
                new ButtonInfo { buttonText = "LowGravity", method =() => lowGrav.LowGravity(), toolTip = "Makes you have low gravity" },
                new ButtonInfo { buttonText = "ZeroGravity", method =() => lowGrav.ZeroGravity(), toolTip = "Makes you have zero gravity" },
                new ButtonInfo { buttonText = "HighGravity", method =() => lowGrav.HighGravity(), toolTip = "Makes you have high gravity" },
                new ButtonInfo { buttonText = "ReverseGravity", method =() => lowGrav.ReverseGravity(), disableMethod =() => unflip.UnflipCharacter(), toolTip = "Reverses gravity on your character."},
                new ButtonInfo { buttonText = "AirSwim", enableMethod =() => AirSwim.airSwim(), disableMethod =() => AirSwim.DisableAirSwim(), toolTip = "Makes you swim in the air"},
                new ButtonInfo { buttonText = "WallWalk", method =() => wallwalk.WallWalk(), toolTip = "Makes you walk on walls" },
                new ButtonInfo { buttonText = "WeakWallWalk", method =() => wallwalk.WeakWallWalk(), toolTip = "Makes you walk on walls" },
                new ButtonInfo { buttonText = "StrongWallWalk", method =() => wallwalk.StrongWallWalk(), toolTip = "Makes you walk on walls" },
                new ButtonInfo { buttonText = "SpiderWalk", method =() => wallwalk.SpiderWalk(), toolTip = "Makes you become a spider" },
            },
            new ButtonInfo[] { // Visual Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "NoName", method =() => NoName.noName(), isTogglable = false, toolTip = "Makes your name nothing" },
                new ButtonInfo { buttonText = "Beacons", method =() => Beacons.Beaconsmod(), toolTip = "Makes players have beacons above them" },
                new ButtonInfo { buttonText = "NoLeaves", enableMethod =() => NoLeaves.EnableRemoveLeaves(), disableMethod =() => NoLeaves.DisableRemoveLeaves(), toolTip = "Makes the leaves disappear"},
                new ButtonInfo { buttonText = "FakeUnbanSelf", method =() => FakeUnbanSelf.fakeUnbanSelf(), toolTip = "Makes it look like your unbaned" },
            },
            new ButtonInfo[] { // Fun Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "Grab Rig", method =() => GrabRig.grabRig(), toolTip = "Grab your rig with grips" },
                new ButtonInfo { buttonText = "Day", method =() => DayStuff.Fun.DayTime(), isTogglable = false},
                new ButtonInfo { buttonText = "Night", method =() => DayStuff.Fun.NightTime(), isTogglable = false},
                new ButtonInfo { buttonText = "Morning", method =() => DayStuff.Fun.MorningTime(), isTogglable = false},
                new ButtonInfo { buttonText = "Eveing", method =() => DayStuff.Fun.EveningTime(), isTogglable = false},
                new ButtonInfo { buttonText = "Rain", method =() => DayStuff.Fun.Rain(), isTogglable = false},
                new ButtonInfo { buttonText = "NoRain", method =() => DayStuff.Fun.NoRain(), isTogglable = false},
           },
            new ButtonInfo[] { // Room Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "Leave", method =() => leave.Leave(), isTogglable = false, toolTip = "Leaves the server" },
                new ButtonInfo { buttonText = "Kill Game", method =() => quitgame.quit(), isTogglable = false, toolTip = "Kills the game" },
            },

            new ButtonInfo[] { // OP Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "MasterCheck", method =() => MasterCheck.MasterCheckerMod(), isTogglable = false},
                new ButtonInfo { buttonText = "GuardianSelf", method =() => GuardianSelf.guardianSelf(), isTogglable = false,},
                new ButtonInfo { buttonText = "GuardianAll", method =() => GuardianAll.guardianAll(), isTogglable = false},
                new ButtonInfo { buttonText = "UnguardianSelf", method =() => UnguardianSelf.unguardianSelf(), isTogglable = false},
              },
             new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false},
                new ButtonInfo { buttonText = "MenuSetings", method =() => SettingsMods.MenuSettings(), isTogglable = false},
            },
             new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.Setting(), isTogglable = false},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.righthanded(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
            },
        };
    }
}