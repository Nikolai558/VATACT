using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatactLibrary.UserConfigurations
{
    public class ArtccConfiguration
    {
        /// <summary>
        /// Save the user ARTCC configuration to a text file so it can be read on next startup.
        /// </summary>
        /// <param name="labels">List of Labels (Prefix Name)</param>
        /// <param name="checkBoxes">List of Checkboxes (Suffix True/False)</param>
        public void SaveArtccConfiguration(List<Label> labels, List<CheckBox> checkBoxes) 
        {
            // C:\Users\%Username%\AppData\Local

        }
    }
}
