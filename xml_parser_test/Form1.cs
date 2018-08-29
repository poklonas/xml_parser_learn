using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace xml_parser_test
{
    public partial class XML_PARSER : Form
    {
        public XML_PARSER()
        {
            InitializeComponent();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFiles_Click(object sender, EventArgs e)
        {
            this.selectFile.ShowDialog();
            string path = this.selectFile.FileName;
            this.pathLabel.Text = path;
            XElement xmlFile = XElement.Load(path);
            if(path == "")
            {
                return;
            }
            this.output_box.Text += xmlFile;
            //foreach( XElement ele in xmlFile.DescendantsAndSelf()){
            //    this.output_box.Text += ele;
            //}
        }
    }
}
