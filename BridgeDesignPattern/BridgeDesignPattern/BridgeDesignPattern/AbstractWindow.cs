using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBridge
{
    public abstract class AbstractWindow
    {
    
        protected IWindowImpl windowImpl;
        protected AbstractWindow(IWindowImpl windowImpl)
        {
            this.windowImpl = windowImpl;
        }
        public void DrawText()
        {
            windowImpl.DrawText();
        }
        public void DrawRectangle()
        {
            windowImpl.DrawLine();
            windowImpl.DrawLine();
            windowImpl.DrawLine();
            windowImpl.DrawLine();
        }


    }
}
