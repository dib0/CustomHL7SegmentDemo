using NHapi.Base;
using NHapi.Base.Log;
using System;

namespace CustomHL7Implementations.V24.Message
{
    [Serializable]
    public class ORU_R01 : NHapi.Model.V24.Message.ORU_R01
    {
        public ORU_R01() : base()
        {
            this.add(typeof(CustomHL7Implementations.V24.Segment.ZVC), true, false);
        }

        public ORU_R01(NHapi.Base.Parser.IModelClassFactory factory)
        : base(factory)
        {
            this.add(typeof(CustomHL7Implementations.V24.Segment.ZVC), true, false);
        }

        public CustomHL7Implementations.V24.Segment.ZVC ZVC
        {
            get
            {
                CustomHL7Implementations.V24.Segment.ZVC ret = null;
                try
                {
                    ret = (CustomHL7Implementations.V24.Segment.ZVC)this.GetStructure("ZVC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }
    }
}
