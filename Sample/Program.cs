using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suprema.SFM_SDK_NET;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            SFM_SDK_NET SFM = new SFM_SDK_NET();
            UF_RET_CODE result = new UF_RET_CODE();
            result = SFM.UF_InitCommPort("COM3", 19200, false);
            Console.WriteLine(result.ToString());
        }
    }
}
