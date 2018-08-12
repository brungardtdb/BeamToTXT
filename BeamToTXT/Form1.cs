using System;
using System.Windows.Forms;
// Tekla Namespace References
// Tekla Structures Namespace References
using Tekla.Structures.Model;

namespace BeamToTXT
{
    public partial class frmBeamToText : Form
    {
        // Instantiate model in class 
        Model Model;
        public bool WriteDataToFile;

        public frmBeamToText()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // If Save All button is selected, set boolean to true
            WriteDataToFile = true;
            // Write data to file
            ThisDataToFile DataToFile = new ThisDataToFile(WriteDataToFile, Model);
        }

        private void frmBeamToText_Load(object sender, EventArgs e)
        {

            // Try to connect to model upon form load
            try
            {
                // Connect Model
                Model = new Model();
            }
            catch
            {
                // Inform user model is not connected if connection fails
                MessageBox.Show("Please Open Tekla Structures");
            }

        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            // If Save Selected button is selected, set boolean to false
            WriteDataToFile = false;
            // Write data to file
            ThisDataToFile DataToFile = new ThisDataToFile(WriteDataToFile, Model);
        }

       

    }
}

