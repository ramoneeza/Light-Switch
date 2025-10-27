using System.Windows.Forms;
namespace Light_Switch
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            ApplicationConfiguration.Initialize();
            Application.Run(new AppContext());
		}
	}
}
