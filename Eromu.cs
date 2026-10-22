using System;
using System.Collections.Generic;
using System.Text;

namespace EromuApp
{
    public class Eromu
    {
        public string Azonosito { get; set; }
        protected int kapacitasKW;
        public int KapacitasKW {
            get
            {
                return kapacitasKW;
            }
            set
            {
                if (value <= 0)
                {
                    value = 100;
                }
            }
        }
        private static int osszeromuSzama;
        public static int OsszeromuSzama { get; }

        public Eromu(string azonosito, int kapacitas, int osszeromuszam)
        {
            Azonosito = azonosito;
            KapacitasKW = kapacitas;
            osszeromuSzama = osszeromuszam;
        }
        public virtual int NapiTermeles(int orakSzama)
        {
            return KapacitasKW * orakSzama;
        }
        public override string ToString()
        {
            return $"Erőmű {Azonosito} | Kapacitás: {KapacitasKW} kW";
        }
    }
}
