using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBridge
{
    public class BoxWindow : AbstractWindow
    {
        public BoxWindow(IWindowImpl windowImpl) : base(windowImpl)
        {
        }
        public void DisplayBox()
        {
            DrawRectangle();
        }

    }
}
