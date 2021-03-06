﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Samochod
    {
        private string marka;
        private int predkoscMax;

        //deklaracja właściwości klasy (property)
        public int Predkosc 
        { 
            get { return predkoscMax; }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Predkosc >=0");
                    string s = Console.ReadLine();
                    predkoscMax = Convert.ToInt32(s);
                }
                else
                {
                    predkoscMax = value;
                }
            }
        }

        public int LiczbaDrzwi { get; set; }

        public Samochod(string marka, int predkosc)
        {
            this.marka = marka;
            predkoscMax = predkosc;
        }

        /// <summary>
        /// Metoda zmienia predkość maks.
        /// </summary>
        /// <param name="predkosc"> nowa prędkość maks.</param>
        public void UstawPredkoscMax(int predkosc)
        {
            predkoscMax = predkosc;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }
    }
}
