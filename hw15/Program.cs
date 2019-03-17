using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hw15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type consoleType = typeof(Console);
            //MethodInfo[] consoleMethods = consoleType.GetMethods();             //1 задание

            //foreach (MemberInfo memberInfo in consoleMethods)
            //{
            //        Console.WriteLine(memberInfo);
            //}
            


            Book book = new Book { Name = "Тарас Бульба", Author = "Н.Гоголь" };

            Type bookType = book.GetType();                   //2 задание

            var bookProperties = bookType.GetRuntimeProperties();

            foreach (var memberInfo in bookProperties)
            {
                Console.WriteLine(memberInfo.Name +": "+ memberInfo.GetValue(book));
            }
        }
    }
}
