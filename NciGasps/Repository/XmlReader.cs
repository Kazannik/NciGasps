using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NciGasps.Repository
{
    class XmlReader
    {

        
  public void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("dictionary.xml");

            List<DepartamentDto> list = new List<DepartamentDto>();

            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Name.ToUpper()== "DIC_RECORD")
                {
                    DepartamentDto dto = GetDto(node);
                    list.Add(dto);
                }

                

               // string name = node.Attributes[0].Value;
                //int age = int.Parse(node["Age"].InnerText);
                //bool programmer = bool.Parse(node["Programmer"].InnerText);
                //listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }


        private DepartamentDto GetDto(XmlNode record)
        {
            int vnkod = 0;
            string znachatr = string.Empty;
            DateTime date_beg = DateTime.MinValue;
            DateTime date_end = DateTime.MaxValue;
            string prim = string.Empty;
            int upkod = 0;
            string nst = string.Empty;
            int vrn_record = 0;

            foreach (XmlNode node in record.ChildNodes)
            {
                if (node.Name.ToUpper() == "VNKOD")
                {
                    vnkod = int.Parse(node.InnerText);
                }
                else if (node.Name.ToUpper() == "ZNACHATR")
                {
                    znachatr = node.InnerText;
                }
                else if (node.Name.ToUpper() == "DATE_BEG" &&
                    node.InnerText.Length > 0)
                {
                    date_beg = DateTime.Parse(node.InnerText);
                }
                else if (node.Name.ToUpper() == "DATE_END" &&
                    node.InnerText.Length > 0)
                {
                    date_end = DateTime.Parse(node.InnerText);
                }
                else if (node.Name.ToUpper() == "PRIM")
                {
                    prim = node.InnerText;
                }
                else if (node.Name.ToUpper() == "UPKOD" &&
                    node.InnerText.Length > 0)
                {
                    upkod = int.Parse(node.InnerText);
                }
                else if (node.Name.ToUpper() == "NST")
                {
                    nst = node.InnerText;
                }
                else if (node.Name.ToUpper() == "VRN_RECORD")
                {
                    vrn_record = int.Parse(node.InnerText);
                }
            }
            return new DepartamentDto(vnkod, znachatr, date_beg, date_end, prim, upkod, nst, vrn_record);
        }

    }


    
}
