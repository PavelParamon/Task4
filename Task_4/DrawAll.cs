using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Task_4
{
    public class DrawAll
    {
        Scene scene1;
        Scene scene2;
        Scene scene3;
        Scene scene4;

        public DrawAll(Scene scene1, Scene scene2, Scene scene3, Scene scene4)
        {
            this.scene1 = scene1;
            this.scene2 = scene2;
            this.scene3 = scene3;
            this.scene4 = scene4;
        }

        public void Set(Bitmap bmp, Graphics g)
        {
            Drawing.Draw(scene1, bmp, g);
            Drawing.Draw(scene2, bmp, g);
            Drawing.Draw(scene3, bmp, g);
            Drawing.Draw(scene4, bmp, g);
        }
    }
}
