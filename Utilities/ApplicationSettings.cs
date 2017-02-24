using System.Windows.Forms;
using SCHOTT.CVLS.Dashboard.Forms;
using SCHOTT.WinForms;

namespace SCHOTT.CVLS.Dashboard.Utilities
{
    public class ApplicationSettings
    {
        public ConnectionSettings ConnectionSettings { get; set; } = new ConnectionSettings();
        public WindowInformation FormSettings { get; set; } = new WindowInformation( 
            FormWindowState.Maximized, 600, 400, new System.Drawing.Point(100,100));
    }
}
