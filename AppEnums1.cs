using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorFinanceiro
{
    class AppEnums1
    {
        public enum tipoPag
        {
            [Description("debito")]
            debito,

            [Description("pix")]
            pix,

            [Description("credito")]
            credito,

            [Description("dinheiro")]
            dinheiro
        }
    }
}
