using System;

namespace ACL
{
    public class Acl
    {

        public int id = 10;
        static protected string s="Shubham";
        protected internal void Ipl()
        {
            Console.WriteLine("Ipl 2021 Winner is Rcb");
        }
        internal void MostWickets()
        {
            Console.WriteLine("Harshal Patel");
        }
        
    }
    public class B : Acl
    { 
       
        public void Print()
        {
            B b1 = new B();
            Console.WriteLine(Acl.s);
            b1.MostWickets();
        }
    }
}
