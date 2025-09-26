using System.Windows.Forms;

namespace AgropecuarioCliente.Utils
{
    public static class MessageHelper
    {
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool ShowConfirmation(string message)
        {
            var result = MessageBox.Show(message, "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}