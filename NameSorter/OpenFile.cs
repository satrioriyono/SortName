using System.Windows.Forms;

namespace NameSorter
{
    /// <summary>
    ///
    /// </summary>
    public static class OpenFile
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <returns></returns>
        public static string readFile()
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = "c:\\";
            dia.Filter =
            "TXT Files (*.txt)|*.txt|" +
            "All Files (*.*)|*.*";
            dia.FilterIndex = 2;
            dia.RestoreDirectory = true;
            if (dia.ShowDialog() == DialogResult.OK)
            {
                return dia.FileName;
            }
            return "";
        }
    }
}