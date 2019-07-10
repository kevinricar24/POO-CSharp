using System;

namespace POO_CSharp.StructsExample
{
    struct StructEntity
    {
        private int id;
        private string title;
        private string author;
        private string subject;

        public void getValues(int i, string t, string a, string s)
        {
            id = i;
            title = t;
            author = a;
            subject = s;
        }

        public void Display()
        {
            Console.WriteLine("Id :{0}", id);
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
        }
    }
}
