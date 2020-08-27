using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SingletonDemo.Classes
{
    public class TelescopeSingleton
    {
        //Singleton properties
        private static TelescopeSingleton _telescope { get; set; }

        private static object SyncLock = new Object();

        //Telescope properties
        private double RightAscension { get; set; }

        private double Declination { get; set; }


        //Private constructor
        private TelescopeSingleton()
        {
            RightAscension = 15.0f;
            Declination = 15.0f;
        }

        //The publicly facing static method for getting an instance of the Singleton
        public static TelescopeSingleton GetInstance()
        {
            if (_telescope is null)
            {
                lock (SyncLock)
                {
                    if (_telescope is null)
                    {
                        _telescope = new TelescopeSingleton();
                    }
                }
            }
            return _telescope;
        }

        //A method to change the state of the telescope object
        public void Slew(double RA, double dec)
        {
            RightAscension = RA;
            Declination = dec;
        }

        public override string ToString()
        {
            return $"\r\nRight Ascension: {String.Format("{0:0.00}", RightAscension)}\r\nDeclination: {String.Format("{0:0.00}", Declination)}";
        }
    }
}
