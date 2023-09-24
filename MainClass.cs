namespace Cube {
    public class MainClass {
        public static void Main() {
            int x = 600, y = 800;
            Window window = new Window("Cube Renderer", x, y);
            Cube cube = new Cube(x,y);
            do {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}