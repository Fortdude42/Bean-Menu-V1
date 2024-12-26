using System;
using System.Collections.Generic;
using System.Text;

namespace Bean_Menu_V1.Mods.Fun_Mods
{
    internal class DayStuff
    {
        public class Fun
        {
            public static void NightTime()
            {
                BetterDayNightManager.instance.SetTimeOfDay(0);
            }

            public static void EveningTime()
            {
                BetterDayNightManager.instance.SetTimeOfDay(7);
            }

            public static void MorningTime()
            {
                BetterDayNightManager.instance.SetTimeOfDay(1);
            }

            public static void DayTime()
            {
                BetterDayNightManager.instance.SetTimeOfDay(3);
            }

            public static void Rain()
            {
                for (int i = 1; i < BetterDayNightManager.instance.weatherCycle.Length; i++)
                {
                    BetterDayNightManager.instance.weatherCycle[i] = BetterDayNightManager.WeatherType.Raining;
                }
            }

            public static void NoRain()
            {
                for (int i = 1; i < BetterDayNightManager.instance.weatherCycle.Length; i++)
                {
                    BetterDayNightManager.instance.weatherCycle[i] = BetterDayNightManager.WeatherType.None;
                }
            }

        }
    }
}
