using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_03.models
{
    class MusicFiles : General
    {
        string Singer { get; set; }
        int Lenght { get; set; }
        public MusicFiles(string singer, int lenght, string name, string code, string category, double size) : base(name,
            code, category, size)
        {
            Singer = singer;
            Lenght = lenght;
        }
        public void Play() { }
        public void RetrieveInformation() { }
    }
}
