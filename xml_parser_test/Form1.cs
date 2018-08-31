using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;

namespace xml_parser_test
{

    public partial class XML_PARSER : Form
    {
        private XElement xmlFileLinq;
        private string path;
        private string maskUp;
        private int mode = 0;
        // using System.Xml.Schema;
        private XmlSchemaSet schemas;

        public XML_PARSER()
        {
            InitializeComponent();
            setMaskUp();
            setSchema();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFiles_Click(object sender, EventArgs e)
        {
            this.output_box.Text = "";
            this.selectFile.ShowDialog();
            this.path = this.selectFile.FileName;
            this.pathLabel.Text = this.path;
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(this.path);
            this.xmlFileLinq = XElement.Load(this.path);
            this.output_box.Text += this.xmlFileLinq;
            this.mode = 1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            XDocument check = new XDocument(this.xmlFileLinq);
            bool checked_doc = false;
            check.Validate(this.schemas, (o, er) => { this.output_box.Text += er.Message;  checked_doc = true;});
            if (!checked_doc)
            {
                this.xmlFileLinq.Save(this.path, SaveOptions.None);
            }
            else{
                MessageBox.Show("คุณได้ เพิ่ม ข้อมูลที่ผิดพลาด ทำให้เซฟไม่ได้");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            XElement newElement = new XElement("food",
                                           new XElement("name", this.input_name.Text),
                                           new XElement("price", this.input_price.Text),
                                           new XElement("description", this.input_descrip.Text),
                                           new XElement("calories", this.input_cal.Text));
            this.xmlFileLinq.LastNode.AddAfterSelf(newElement);
            if (this.mode == 1)
            {
                this.output_box.Text += newElement;
            }
            else if(this.mode == 2)
            {
                this.output_box.Text = "";
                IEnumerable<XElement> foods = from food in this.xmlFileLinq.Descendants("name") select food;
                foreach (XElement element in foods)
                {
                    this.output_box.Text += (element.Value + "\r\n");
                }
            }
        }

        private void output_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void setMaskUp()
        {
            this.maskUp =
            @"<xsd:schema xmlns:xsd='http://www.w3.org/2001/XMLSchema'>  
               <xsd:element name='breakfast_menu'>  
                <xsd:complexType>  
                 <xsd:sequence>
                   <xsd:element name='food'>  
                    <xsd:complexType>  
                     <xsd:sequence>
                       <xsd:element name='name' type='xsd:string'/>  
                       <xsd:element name='price' type='xsd:decimal'/>  
                       <xsd:element name='description' type='xsd:string'/>  
                       <xsd:element name='calories' type='xsd:integer'/>  
                     </xsd:sequence>  
                    </xsd:complexType>  
                  </xsd:element>  
                 </xsd:sequence>  
                </xsd:complexType>  
               </xsd:element>  
              </xsd:schema>";
        }

        private void setSchema()
        {
            this.schemas = new XmlSchemaSet();
            // using System.IO for StringReader;
            this.schemas.Add("", XmlReader.Create(new StringReader(this.maskUp)));
        }

        private void only_name_Click(object sender, EventArgs e)
        {
            this.output_box.Text = "";
            IEnumerable<XElement> foods = from food in this.xmlFileLinq.Descendants("name") select food;
            foreach (XElement element in foods)
            {
                this.output_box.Text += (element.Value + "\r\n");
            }
            this.mode = 2;
        }

        private void allSchema_Click(object sender, EventArgs e)
        {
           this.output_box.Text = "";
           this.output_box.Text += this.xmlFileLinq;
           this.mode = 1;
        }
    }
}
