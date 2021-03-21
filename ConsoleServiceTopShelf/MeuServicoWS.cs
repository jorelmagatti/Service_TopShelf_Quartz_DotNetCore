using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleServiceTopShelfQuartz
{
    public class MeuServicoWS
    {
        public void Start()
        {
            ExecutaRotinasQuartz.StartaRotinas();
        }

        public void Stop()
        {
            ExecutaRotinasQuartz.StopaRotina();
        }
    }
}
