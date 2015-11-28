﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class backend
    {

        //Product Information Loader from Text
        public void prodinfoText(String location)
        {
            string[] lineparsed = System.IO.File.ReadAllLines(@location);

            foreach (string line in lineparsed)
            {
                

                //Object Creation initializes here
                /*
                Product cosmopolitan = new Product(13.79, "Cosmopolitan", 1);
                Product archidaily = new Product(50.60, "Archi Daily", 2);
                Product Travelz = new Product(14.60, "Travelz",3);
                */

                //Product array initalization
                Product[] ProductArr = new Product[3] { new Product(13.79, "Cosmopolitan", 0, null),
                new Product(50.60, "Archi Daily", 1, null),new Product(14.60, "Travelz", 2, null)};
            }
        }

        public void LoadDesc()
        {
            //string liner;

            System.IO.StreamReader file = new System.IO.StreamReader("c:\\loadprod.txt");
            //while ((liner = file.ReadLine()) != null)
            for (int i = 0; i < file.ReadLine().Length; i++)
            {
                Product[i].Desc = file.ReadLine();
            }
            file.Close();

        }

        public void testProdDesc()
        {
            System.IO.StreamReader theFile = new System.IO.StreamReader("C:\\loadprod.txt");
            String DescString = theFile.ReadToEnd();

            theFile.Close();

            /**
            Custom File Loader
            Displays all contents
            **/
            Console.WriteLine(DescString);
        }
    }
}
