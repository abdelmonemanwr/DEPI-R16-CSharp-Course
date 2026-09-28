using OOP.PIV.IS_A;
using OOP.PIV.Sealed;

namespace OOP.PIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // function xyz(Parent p);
            // xyz(new child())
            // parent p = new child();

            //Parent p = new Parent(3, 5);
            //p.Show(); // 3,5,-1

            //Child c = new Child(10);
            //c.Show(); // 10, -1, -1, -1

            //Parent p = new Child();
            //Child c = new Parent(); // error



            //Parent p = new Child(10); // override, method_hidden
            //p.Show();

            //Parent p = new SubChild(10); // override, method_hidden
            //p.Show(); // a=10,z=12,x=15,s=25,y=-1


            //User u = new User();  // coz it's abstract
            // can't take object | can inherit from it

            //CEO ceo = new CEO(); // it's okay coz it's sealed   
            // //ceo.

            // take object | can't inherit from it | sealed class can inherit from other classes
        }
    }
}
