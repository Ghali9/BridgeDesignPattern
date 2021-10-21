using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBridge
{
    public class ButtonWindow : AbstractWindow
    {
        public ButtonWindow(IWindowImpl windowImpl) : base(windowImpl)
        {
        }

        public void DisplayButton()
        {
            DrawRectangle();
            DrawText();
        }
    }
}
