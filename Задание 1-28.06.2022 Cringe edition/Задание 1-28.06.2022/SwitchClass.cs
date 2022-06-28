using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_28._06._2022
{
    class SwitchClass
    {
        private Secundomer secundomer;
        public SwitchClass(Secundomer secundomer)
        {
            this.secundomer = secundomer;
        }
        public Secundomer Start()
        {
            secundomer.Start();
            return secundomer;
        }
        public Secundomer Stop()
        {
            secundomer.Stop();
            return secundomer;
        }
        public Secundomer Reset()
        {
            secundomer.Reset();
            return secundomer;
        }
    }
}
