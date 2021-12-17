//https://www.youtube.com/watch?v=Glfz0FDPfXk
using System.Linq.Expressions;

namespace ExpressionTree
{
    public class ExpressionTree
    {
        public static void Main()
        {
            MyClass mC = new MyClass();

            //Func -> Delegate para métodos com retorno
            Func<MyClass, int> myDelegate = myClass => myClass.SumValues(2, 8);

            Console.WriteLine(myDelegate(mC));
            Console.WriteLine(myDelegate.Invoke(mC));

            //Action -> Delegate para métodos sem nenhum retorno
            Action<MyClass> myActionDelegate = myClass => myClass.PrintHelloWorld();

            myActionDelegate(mC);
            myActionDelegate.Invoke(mC);

            //Expression

            Expression<Func<MyClass, int>> myExpression = myClass => myClass.SumValues(3, 4);
            Expression<Action<MyClass>> myExpression2 = myClass => myClass.PrintHelloWorld();

        }
    }
}