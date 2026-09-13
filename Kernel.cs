using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;
using System.Xml.Schema;

namespace cosmosPlanet
{
    

    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0;static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true) 
            {  
                graf.starts();
                
                while (true)
                {
                        Thread.Sleep(2);
                     
                        tests.mainLoop();
    

                    
                    ;

                }
            }
            
            
        }
    }





    class tests



    {
        static int x=200;static int y=400;static int xx=10; static int yy=10;

        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 1);
            Pen p1 = new Pen(Color.Gray, 1);
            graf.canvas.Clear(Color.White);





            if (xx >= 0)
            {
                Sys.Graphics.Point pp = new Sys.Graphics.Point((int)500, 400);
                graf.canvas.DrawFilledEllipse(p, pp, 150, 150);
                Sys.Graphics.Point ppp = new Sys.Graphics.Point((int)x, (int)y);
                graf.canvas.DrawFilledEllipse(p1, ppp, 50, 50);
            }
            else 
            {
                Sys.Graphics.Point ppp = new Sys.Graphics.Point((int)x,(int)y);
                graf.canvas.DrawFilledEllipse(p1, ppp, 50, 50);
                Sys.Graphics.Point pp = new Sys.Graphics.Point((int)500, 400);
                graf.canvas.DrawFilledEllipse(p, pp, 150, 150);



            }
            x = x + xx;
            if (x < 200 || x > 700) xx = -xx;
            graf.displays();
            
            
        }

    }





}
