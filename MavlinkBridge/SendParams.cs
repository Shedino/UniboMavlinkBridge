using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MavlinkBridge
{
    public enum UAVType
    {
        OVERRIDE,
        ATECH,
        IRIS
    }
    public class SendParams
    {

        //parameters
        float _offset = 0;

        public float Offset
        {
            get
            {
                float retval = _offset;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.1f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _offset = value; }
        }
        float _mass = 0;

        public float Mass
        {
            get
            {
                float retval = _mass;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 1.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 1.35f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _mass = value; }
        }
        float _delta = 0;

        public float Delta
        {
            get
            {
                float retval = _delta;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.1f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.1f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _delta = value; }
        }
        float _K1 = 0;

        public float K1
        {
            get
            {
                float retval = _K1;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 7.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 7.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _K1 = value; }
        }
        float _L1 = 0;

        public float L1
        {
            get
            {
                float retval = _L1;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 18.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 18.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _L1 = value; }
        }
        float _Ixy = 0;

        public float Ixy
        {
            get
            {
                float retval = _Ixy;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.02f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.02f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _Ixy = value; }
        }
        float _K2 = 0;

        public float K2
        {
            get
            {
                float retval = _K2;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 70.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 70.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _K2 = value; }
        }
        float _L2 = 0;

        public float L2
        {
            get
            {
                float retval = _L2;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 200.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 200.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _L2 = value; }
        }
        float _Iz = 0;

        public float Iz
        {
            get
            {
                float retval = _Iz;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.04f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.03f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _Iz = value; }
        }
        float _KpAttX = 0;

        public float KpAttX
        {
            get
            {
                float retval = _KpAttX;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 2.4f;
                        break;
                    case UAVType.IRIS:
                        retval = 2.5f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KpAttX = value; }
        }
        float _KpAttY = 0;

        public float KpAttY
        {
            get
            {
                float retval = _KpAttY;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 2.4f;
                        break;
                    case UAVType.IRIS:
                        retval = 2.4f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KpAttY = value; }
        }
        float _KpAttZ = 0;

        public float KpAttZ
        {
            get
            {
                float retval = _KpAttZ;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 1.5f;
                        break;
                    case UAVType.IRIS:
                        retval = 2.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KpAttZ = value; }
        }
        float _KdAttX = 0;

        public float KdAttX
        {
            get
            {
                float retval = _KdAttX;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.14f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.19f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KdAttX = value; }
        }
        float _KdAttY = 0;

        public float KdAttY
        {
            get
            {
                float retval = _KdAttY;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.14f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.19f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KdAttY = value; }
        }
        float _KdAttZ = 0;

        public float KdAttZ
        {
            get
            {
                float retval = _KdAttZ;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.14f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.19f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KdAttZ = value; }
        }
        float _KiAttX = 0;

        public float KiAttX
        {
            get
            {
                float retval = _KiAttX;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KiAttX = value; }
        }
        float _KiAttY = 0;

        public float KiAttY
        {
            get
            {
                float retval = _KiAttY;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KiAttY = value; }
        }
        float _KiAttZ = 0;

        public float KiAttZ
        {
            get
            {
                float retval = _KiAttZ;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.01f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.01f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _KiAttZ = value; }
        }
        float _GE = 0;

        public float GE
        {
            get
            {
                float retval = _GE;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _GE = value; }
        }
        float _epsilon = 0;

        public float Epsilon
        {
            get
            {
                float retval = _epsilon;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.06f; //20
                        break;
                    case UAVType.IRIS:
                        retval = 0.06f; //20
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _epsilon = value; }
        }
        float _XY_mult = 0;

        public float XY_mult
        {
            get
            {
                float retval = _XY_mult;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 1.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 1.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _XY_mult = value; }
        }
        float _Jxy = 0;

        public float Jxy
        {
            get
            {
                float retval = _Jxy;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0088f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.0088f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _Jxy = value; }
        }
        float _Jz = 0;

        public float Jz
        {
            get
            {
                float retval = _Jz;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 0.0176f;
                        break;
                    case UAVType.IRIS:
                        retval = 0.0176f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _Jz = value; }
        }
        float _offset_yaw = 0;

        public float Offset_yaw
        {
            get
            {
                float retval = _offset_yaw;
                switch (SendType)
                {
                    case UAVType.ATECH:
                        retval = 87.0f;
                        break;
                    case UAVType.IRIS:
                        retval = 80.0f;
                        break;
                    default:
                        //Override o altro?
                        break;
                }
                return retval;
            }
            set { _offset_yaw = value; }
        }

        UAVType __type = UAVType.OVERRIDE;

        public UAVType SendType
        {
            get { return __type; }
            set { __type = value; }
        }



    }
}
