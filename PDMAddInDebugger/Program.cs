using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMAddInDebugger
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            var ConsoleDefaultColor = Console.ForegroundColor ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(string.Format("CADSharp LLC - {0} {1} - Amen Jlili (amen@cadsharp.com)", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion));
            Console.ForegroundColor = ConsoleDefaultColor;
            Console.WriteLine(string.Format("Debugging started at: {0}", DateTime.Now));
            var Dialog = new System.Windows.Forms.OpenFileDialog();
            Dialog.Multiselect = true;
            Dialog.Filter = "All files (*.*)|*.*";
            if (args == null || args.Length == 0)
            {
                args = new string[] { string.Empty};
            }

            string directory = args[0];
            if (string.IsNullOrWhiteSpace(directory))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Path is empty. Debugger will browse to your desktop."));
                Console.ForegroundColor = ConsoleDefaultColor;
                directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (!System.IO.Directory.Exists(directory))
            {
                Console.WriteLine($"{directory} is not a valid path.");
                Console.WriteLine(string.Format("Debugging ended at: {0}", DateTime.Now));
                Console.ReadKey();
                return;
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Dialog.InitialDirectory = directory;
            Dialog.ShowDialog();
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------"); 
            Console.ReadLine();
            Console.WriteLine(string.Format("Debugging ended at: {0}", DateTime.Now));
            Console.ReadKey();
        }

        
    }
    
}
