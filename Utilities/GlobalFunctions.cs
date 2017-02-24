using System.Windows.Forms;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.WinForms.Dialogs;

namespace SCHOTT.CVLS.Dashboard.Utilities
{
    public static class GlobalFunctions
    {
        public static void BinaryLogin(BinarySocket binarySocket)
        {
            var userNameConfig = new DialogConfiguration
            {
                Message = "Please enter your username.",
                Title = "Username Prompt",
                ButtonOptions = MessageBoxButtons.OKCancel,
                UserEntryFieldIsVisible = true
            };

            var passwordConfig = new DialogConfiguration
            {
                Message = "Please enter your password.",
                Title = "Password Prompt",
                ButtonOptions = MessageBoxButtons.OKCancel,
                UserEntryFieldIsVisible = true,
                UserEntryFieldIsPassword = true
            };

            if (CrossThreadDialogs.MessageBoxBlocking(userNameConfig) == DialogResult.OK &&
                CrossThreadDialogs.MessageBoxBlocking(passwordConfig) == DialogResult.OK)
            {
                binarySocket.Login(userNameConfig.ResultUserInput, passwordConfig.ResultUserInput);
            }
        }
    }
}
