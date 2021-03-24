using System;
using System.Collections.Generic;
using System.Text;

namespace factory.Interface
{
    interface ITechnicChar
    {
        string model { get; set; }

        string type { get; set; }

        string logo { get; set; }

        string color { get; set; }

        string drive { get; set; }

        string fuel { get; set; }

        string engine { get; set; }

        int price { get; set; }
    }
}
