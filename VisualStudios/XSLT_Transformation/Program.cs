using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace XSLT_Transformation
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(@"C:\XML_Test\wordcount.xsl");
                transform.Transform(@"C:\XML_Test\hello.xml", @"C:\XML_Test\output.xml");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
