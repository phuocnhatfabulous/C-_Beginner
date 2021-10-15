using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace UI1
{
    public class Classtheme
    {
        //Extern methods
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        private static extern uint GetImmersiveColorFormColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType,
            bool bIgnoreHighContrast, uint dwHighContrastCacheMode );

        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        private static extern uint GetImmersiveColorTypeFormname(IntPtr pName);

        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        //Public methods
        public static Color GetAccentColor()
        {
            var userColorSet = GetImmersiveUserColorSetPreference(false, false);
            var colorType = GetImmersiveColorTypeFormname(Marshal.StringToHGlobalUni("ImmersiveStartSelectBackground"));
            var colorSetEx = GetImmersiveColorFormColorSetEx((uint)userColorSet, colorType, false, 0);

            return ConvertDWordColorToRGB(colorSetEx);
        }

        //Private methods
        private static Color ConvertDWordColorToRGB(uint colorSetEx)
        {
            byte redColor = (byte)((0x000000FF & colorSetEx)>>0);
            byte greenColor = (byte)((0x0000FF00 & colorSetEx)>>8);
            byte blueColor = (byte)((0x00FF0000 & colorSetEx) >> 16);

            return Color.FromArgb(redColor, greenColor, greenColor);
        }
    }
}
