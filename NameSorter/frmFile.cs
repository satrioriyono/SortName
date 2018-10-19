using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NameSorter
{
    /// <summary>
    /// Creator : Satrio R. Sidik
    /// Date : 2018-10-19
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmFile : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmFile"/> class.
        /// </summary>
        public frmFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the cmdClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the cmdFind control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmdFind_Click(object sender, EventArgs e)
        {
            txtFileName.Text = OpenFile.readFile();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtFileName control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length > 0)
            {
                var lines = File.ReadLines(txtFileName.Text)
                     .OrderBy(x => x[0]).ToList();
                string output = "";
                foreach (var line in lines)
                {
                    lst.Items.Add(line);
                    output += line+ Environment.NewLine;
                }
                File.WriteAllText(Application.StartupPath + "\\sorted-names-lists.txt", output);

            }
        }

        /// <summary>
        /// Handles the Load event of the frmFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmFile_Load(object sender, EventArgs e)
        {
        }
    }
}