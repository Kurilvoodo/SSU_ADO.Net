using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSUOOPTask1
{
    #region struct PointY
    public struct PointY
    {
        private double _x;
        public double X
        {
            get
            {
                return _x;
            }
        }
        private double _y;
        public double Y
        {
            get
            {
                return _y;
            }
        }
        public PointY(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", _x, _y);
        }
    }
    #endregion
    #region struct PointZ
    public struct PointZ
    {
        private double _x;
        public double X
        {
            get
            {
                return _x;
            }
        }
        private double _y;
        public double Y
        {
            get
            {
                return _y;
            }
        }
        private double _z;
        public double Z
        {
            get 
            {
                return _z;
            }
        }
        public PointZ(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", _x, _y, _z);
        }
    }
    #endregion
    class Pyramid
    {
        private PointY _a;
        #region Public PointY A
        public PointY A
        {
            get
            {
                return _a;
            }
            set
            {
                if (B.X != value.X && B.Y != value.Y &&
                    C.X != value.X && C.Y != value.Y &&
                    D.X != value.X && D.Y != value.Y)
                {
                    _a = value;
                }
                else
                {
                    throw new Exception("Points in pyramid can't be the same!");
                }
            }
        }
        #endregion
        private PointY _b;
        #region Public PointY B
        public PointY B
        {
            get
            {
                return _b;
            }
            private set
            {
                if (A.X != value.X && A.Y != value.Y &&
                    C.X != value.X && C.Y != value.Y &&
                    D.X != value.X && D.Y != value.Y)
                {
                    _b = value;
                }
                else
                {
                    throw new Exception("Points in pyramid can't be the same!");
                }
            }
        }
        #endregion
        private PointY _c;
        #region Public PointY C
        public PointY C
        {
            get
            {
                return _c;
            }
            private set
            {
                if (B.X != value.X && B.Y != value.Y &&
                    A.X != value.X && A.Y != value.Y &&
                    D.X != value.X && D.Y != value.Y)
                {
                    _c = value;
                }
                else
                {
                    throw new Exception("Points in pyramid can't be the same!");
                }
            }
        }
        #endregion
        private PointY _d;
        #region Public PointY D
        public PointY D
        {
            get
            {
                return _d;
            }
            private set
            {
                if (B.X != value.X && B.Y != value.Y &&
                    C.X != value.X && C.Y != value.Y &&
                    A.X != value.X && A.Y != value.Y)
                {
                    _d = value;
                }
                else
                {
                    throw new Exception("Points in pyramid can't be the same!");
                }
            }
        }
        #endregion
        private PointZ _e;
        #region Public PointZ E
        public PointZ E
        {
            get
            {
                return _e;
            }
        }
        #endregion
        private PointZ _f; // point of the height for some reason delete further if don't like it
        #region Public PointZ F
        public PointZ F
        {
            get
            {
                return _f;
            }
        }
        #endregion
        public Pyramid(PointY a, PointY b, PointY c, PointY d, PointZ e)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
            this._e = e;
        }
        public double FoundationPerimeter
        {
            get 
            {
                return Math.Sqrt((B.X-A.X)* (B.X - A.X) + (B.Y - A.Y)*(B.Y - A.Y))+
                    Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y)) +
                    Math.Sqrt((D.X - C.X) * (D.X - C.X) + (D.Y - C.Y) * (D.Y - C.Y)) +
                    Math.Sqrt((A.X - D.X) * (A.X - D.X) + (A.Y - D.Y) * (A.Y - D.Y));
            }
        }
        
       public double HalfPerim
        {
            get 
            {
               return FoundationPerimeter / 2.0;
            }
        }
        public double FoundationSquare
        {
            get
            {
                return Math.Sqrt(
                    (HalfPerim - Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)))*  
                    (HalfPerim - Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y)))*
                    (HalfPerim - Math.Sqrt((D.X - C.X) * (D.X - C.X) + (D.Y - C.Y) * (D.Y - C.Y)))*
                    (HalfPerim - Math.Sqrt((A.X - D.X) * (A.X - D.X) + (A.Y - D.Y) * (A.Y - D.Y)))
                    );
            }
        }
        public double V()
        {
            return (1.0 / 3.0) * FoundationSquare * E.Z;
        }
    }
}
