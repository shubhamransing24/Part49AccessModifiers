using System;
using ACL;
namespace Part49AccessModifiers
{
    class Program :Acl
    {

        static void Main(string[] args)
        {
            Acl xyz = new Acl();
            Console.WriteLine(xyz.id);
            B b = new B();
            b.Print();
            Program p = new Program();
            p.Ipl();
            
            
        }
    }
}
