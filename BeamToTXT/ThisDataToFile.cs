using System.IO;
using System.Windows.Forms;
// Tekla Namespace References
// Tekla Structures Namespace References
using Tekla.Structures.Model;
using TSMUI = Tekla.Structures.Model.UI;


namespace BeamToTXT
{
    class ThisDataToFile
    {
        private bool allObjects;
        private Model model;

        public bool AllObjects
        {
            get
            {
                return this.allObjects;
            }
            set
            {
                allObjects = value;
            }
        }
        public Model Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public ThisDataToFile(bool allObjects, Model model)
        {
            this.AllObjects = allObjects;
            this.Model = model;

            ModelObjectEnumerator ModelObjectsToWriteOut = null;
            if (allObjects)
            {
                // Select all objects in the model that are beams and add to enumeration
                ModelObjectsToWriteOut = model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);
            }
            else
            {
                // use model object selector to get selected objects
                TSMUI.ModelObjectSelector GetSelectedObjects = new TSMUI.ModelObjectSelector();
                // Get selected objects in model and add to enumeration
                ModelObjectsToWriteOut = GetSelectedObjects.GetSelectedObjects();
            }

            // get file name
            string FileName = "BeamsToTextFile";
            // Write directly into model folder using System.IO namespace. 
            string FinalFileName = Path.Combine(model.GetInfo().ModelPath, FileName);
            // use new StreamWriter from System.IO to write new text file in specified location
            using (StreamWriter FileWriter = new StreamWriter(FinalFileName))
            {

                while (ModelObjectsToWriteOut.MoveNext())
                {
                    // Move through beams in collection
                    Beam ThisBeam = ModelObjectsToWriteOut.Current as Beam;
                    if (ThisBeam != null)
                    {
                        string DataLineForFile = "GUID: " + model.GetGUIDByIdentifier(ThisBeam.Identifier) + "," +
                          "Profile: " + ThisBeam.Profile.ProfileString + "," + // Write beam profile
                           "Material: " + ThisBeam.Material.MaterialString + "," + // write beam material
                           "Class: " + ThisBeam.Class; // write beam class                      

                        FileWriter.WriteLine(DataLineForFile);
                    }
                }
            }

            // Inform user that file has been exported
            MessageBox.Show("File Exported");
            Tekla.Structures.Model.Operations.Operation.DisplayPrompt("File Exported and Written to Model Folder");

        }

    }
}
