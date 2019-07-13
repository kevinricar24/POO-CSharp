using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.PropertyExample
{
    class Property
    {
        public string myField1;
        private string myField2 = "hello";
        private string myField3;
        private string myField4;
        public string MyProperty1 { get; set; }

        public string MyProperty2
        {
            get
            {
                Console.WriteLine("MyProperty2 ReadOnly");
                return myField2.ToUpper();
            }
        }

        public string MyProperty3
        {
            set
            {
                Console.WriteLine("MyProperty3 WriteOnly");
                myField3 = value;
            }
        }

        public string MyProperty4
        {
            get {return myField4;}
            set { myField4 = value; }
        }

        private string myProjection;

        //C# using expression body
        public string MyProjection
        {
            get => myProjection;           // C# version 6.0+         
            set => myProjection = value;   // C# version 7.0+
        }


    }
}
