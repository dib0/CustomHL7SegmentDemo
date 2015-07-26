using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHapi.Model.V24.Message;
using CustomHL7Implementations.V24.Message;
using CustomHL7Implementations.V24.Segment;
using NHapi.Base.Parser;

namespace CustomHL7SegmentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PipeParser parser = new PipeParser();

            CustomHL7Implementations.V24.Message.ORU_R01 orur01 = new CustomHL7Implementations.V24.Message.ORU_R01();
            orur01.ZVC.EstadoAutorizacion.Text.Value = "1234";

            string msg = parser.Encode(orur01);

            ZVC oZVC = (ZVC)orur01.GetStructure("ZVC");
            oZVC.EstadoAutorizacion.Text.Value = "1234";
            msg = parser.Encode(orur01);
        }
    }
}
