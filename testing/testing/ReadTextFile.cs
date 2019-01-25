using System;
using System.Collections.Generic;
using System.Text;

namespace testing
{
    class ReadTextFile
    {

        int counter = 0;
        string line;
        public void ReadFile()
        {
            
            System.IO.StreamReader file = new System.IO.StreamReader(@"\Users\102622\testing\text1.txt");
            while((line = file.ReadLine()) !=null)
            {
                Console.WriteLine(line);
                counter++;

            }
            file.Close();
               
        }
    }
}
