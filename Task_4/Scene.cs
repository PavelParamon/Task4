using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Task_4
{
    public class Scene
    {


        public Trolleybus trolleybus;
        public Driver driver = new Driver();
        public Service service;
        int ws;

        static object locker = new object();

        public Scene(int ws, int num)
        {
            this.ws = ws;

            trolleybus = new Trolleybus(0, 20 * num, 7);
            service = new Service(0, 20 * num, 7);
            driver.TrolleybusSet = trolleybus;
            service.TrolleybusSet = trolleybus;
        }


        public void Set(int ws)
        {
           trolleybus.Set(ws);
           service.Set(ws); 
           driver.Set();
            
        }

    }
}
