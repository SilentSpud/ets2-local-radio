using DeftSharp.Windows.Input.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Radio_Server
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      KeyboardListener keyboardListener = new KeyboardListener();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Main(keyboardListener));
    }
  }
}
