namespace Cube {
    public class Cube {
        private Point2D _pos;
        private Vector3 _rot;
        private Quad[] _sides;
        public Cube(int x, int y) : this(x, y, 45, 45, 45) { }
        public Cube(int x, int y, double rx, double ry, double rz) {
            _pos = new Point2D();
            _pos.X = x;
            _pos.Y = y;
            _rot = new Vector3(rx, ry, rz);
            _sides = new Quad[] { };
        }
        public Point2D Position { 
            get { 
                return _pos; 
            } set {
                _pos = value;
            }
        }
        public Vector3 Rotation {
            get {
                return _rot;
            } set {
                _rot.X = value.X % 360;
                _rot.Y = value.Y % 360;
                _rot.Z = value.Z % 360;
            }
        }
        public void Draw() {
            for (int i = 0; i < 6; i++) {
                _sides[i].Points = new Point2D[]();
                SplashKit.FillQuad(_sides[i]);
            }
        }
        public void Rotate(Vector3 rotateBy) {
            _rot.X = (_rot.X + rotateBy.X) % 360;
            _rot.Y = (_rot.Y + rotateBy.Y) % 360;
            _rot.Z = (_rot.Z + rotateBy.Z) % 360;
        }
    }
}