using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Interface
{
    interface ITechnic
    {
        public ITechnicChar GetTechnicChar();

        public int GetTechnicCount();

        public int GetTechnicID();

    }
}
