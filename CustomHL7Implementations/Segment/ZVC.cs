using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V24.Datatype;
using System;

namespace CustomHL7Implementations.V24.Segment
{
    [Serializable]
    public sealed class ZVC : AbstractSegment
    {
        public ZVC(IGroup parent, IModelClassFactory factory)
        : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                add(typeof(EI), true, 0, 1, new object[] { message }, "NroControlDelPrestador");
                add(typeof(CE), false, 0, 1, new object[] { message }, "NroControlDelFinanciador");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
            }
        }

        public EI NroControlPrestador
        {
            get
            {
                EI ret; try { IType t = GetField(1, 0); ret = (EI)t; }
                catch (HL7Exception he)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("U nexpected problem obtaining field value. This is a bug.", he);
                    throw new Exception("An unexpected error ocurred", he);
                }
                catch (Exception ex)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value. This is a bug.", ex);
                    throw new Exception("An unexpected error ocurred", ex);
                } return ret;
            }
        }

        public CE EstadoAutorizacion
        {
            get
            {
                CE ret; try { IType t = GetField(2, 0); ret = (CE)t; }
                catch (HL7Exception he)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value. This is a bug.", he);
                    throw new Exception("An unexpected error ocurred", he);
                }
                catch (Exception ex)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value. This is a bug.", ex);
                    throw new Exception("An unexpected error ocurred", ex);
                } return ret;
            }
        }
    }
}