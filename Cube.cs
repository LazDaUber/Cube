namespace Cube {
    public class Cube {
        private Point2D _pos;
        private Vector3 _rot;
        private Quad[] sides;
        public Cube(int x, int y) : this(45,) { }
        public Cube(int x, int y, Vector3 r) : this(x,y) { }
        public Cube(int x, int y, double rx, double ry, double rz) {
            _pos = new Point2D();
            _pos.X = x;
            _pos.Y = y;
            _rot = new Vector3(rx, ry, rz);
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
                _rot = value;
            }
        }
        public void Draw() {

        }
        public void Rotate() {

        }
    }
}