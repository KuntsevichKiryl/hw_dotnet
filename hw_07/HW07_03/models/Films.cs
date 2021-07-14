using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07_03.models
{
    class Films : General
    {
        string Director { get; set; }
        string MainActor { get; set; }
        string MainActress { get; set; }
        public Films(string director, string mainActor, string mainActress, string name, string code,
            string category, double size): base(name,code, category, size)
        {
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
        }
        public void Play() { }
        public void RetrieveInformation() { }
    }
}
