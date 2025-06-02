using Astrolabe.models;

namespace Astrolabe
{
    internal static class Astrolabe
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //double ra = 37.9545;    // ������� ����
            //double dec = 89.2641;
            //double lat = 50.45;     // ���
            //double lon = 30.52;
            //DateTime utc = DateTime.UtcNow;

            //bool visible = StarVisibility.IsStarVisible(ra, dec, lat, lon, utc);

            //MessageBox.Show("ǳ��� " + (visible ? "������" : "��������") + " � ���.");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        internal class models
        {
            internal class Star
            {
            }
        }
    }
}