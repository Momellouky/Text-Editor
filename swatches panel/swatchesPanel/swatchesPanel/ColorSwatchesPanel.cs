using System;

namespace swatchesPanel
{
    public class ColorSwatchesPanel
    {
        /* 
         * STEPS:
         * ----------------------
         * load form 
         * load close btn 
         * load default color 
         * load color panel
         * load rgb textboxes
         * ----------------------
         */

        // default values. 

        public int panel_width = 500;
        public int panel_height = 300;
        public enum primary_color  { red = 21 , green = 33 , blue = 61 }; 
        public enum secondary_color { red = 242, green = 156, blue = 17 };

        public int color_square_width = 35;
        public int color_square_height = 34;

        public int color_panel_width = 400;
        public int color_panel_height = 70; 

        // load form 

        public static void loadForm()
        {

        }
         
        
        
    }
}
