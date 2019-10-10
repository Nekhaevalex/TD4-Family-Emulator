using System;
using System.Collections.Generic;

namespace CLIWindows
{
    struct point
    {
        char figure;
        byte foreground;
        byte background;
    }

    public static class WindowServer
    {
        public static int WindowWidth {
            get {

                return Console.WindowWidth;
            }
            set => Console.WindowWidth = value; }
        public static int WindowHeight { get => Console.WindowHeight; set => Console.WindowHeight = value; }

        public static Stack<Window> windows = new Stack<Window>();

        private static point[][] Canvas {
            set
            {

            }
        }
        
    }
}
