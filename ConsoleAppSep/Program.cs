//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppSep
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Welcome to C#");
//            //Console.WriteLine("This is nex line");
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //Console.WriteLine("Main ends");

//            //using Read() method
//            // int charUnicode;
//            // Console.WriteLine("Enter any character");

//            //charUnicode= Console.Read();
//            // Console.WriteLine("char unicode is:"+charUnicode);

//            //int id;
//            //string name;
//            //float salary;
//            //char grade;

//            //Console.WriteLine("Input details");

//            //Console.WriteLine("Enter ID:");
//            //id = Int32.Parse(Console.ReadLine());//parsing string to int

//            //Console.WriteLine("Enter Name:");//no need to parse
//            //name = Console.ReadLine();

//            //Console.WriteLine("Enter Salary");
//            //salary=Single.Parse(Console.ReadLine());

//            //Console.WriteLine("Enter Grade");
//            //grade=char.Parse(Console.ReadLine());


//            //Int32Parse(string);
//            //Single.Parse(string);
//            //char.Parse(string);

//            //Console.WriteLine("Deatials are:");
//            //Console.Write("ID:"+id);
//            //Console.Write("\tName:" +name);
//            //Console.Write("\tSalary:" +salary);
//            //Console.Write("\tGrade:" +grade);

//            //Console.WriteLine("ID:"+id+"\tName:"+name+"\tSalary"+salary+"\tGrade:"+grade);
//            // Console.WriteLine("ID:"{0}"\tName:"{ 1}"\tSalary"{2} "\tGrade:"{3},id,name,salary,grade);

//            //Console.WriteLine("Press any key:");
//            //ConsoleKeyInfo ck = Console.ReadKey();

//            //ConsoleKeyInfo ck = Console.ReadKey(true);
//            //Console.Write("*");

//            //Console.WriteLine("\nPressed Key:" + ck.Key);//return an enum value of type consolekeyinfo
//            //Console.WriteLine("Pressed charkey:" + ck.KeyChar);//returns char value

//            // Password end after enter key press
//            // Console.Write("Enter Password:");
//            // string pwd = "";
//            // ConsoleKeyInfo ck = Console.ReadKey(true);

//            //while (ck.Key != ConsoleKey.Enter)
//            // {
//            //     Console.Write("*");
//            //     pwd = pwd + ck.KeyChar;
//            //    ck =Console.ReadKey(true);
//            // }


//            // Console.WriteLine("\nPassword is:{pwd}");

//            // Boxing-> conversion from value type to reference type
//            /*
//            int x = 20;
//            object obj = x;//boxing, implicit
//            Console.WriteLine($"value:{obj}\t type:{obj.GetType()}");//20,object

//            // UnBoxing-> conversion from reference type to value type
//            //boxed val;ues can be unboxed only in same type
//            int y = (int)obj;
//            Console.WriteLine($"value:{y}\t type:{y.GetType()}");//20,int

//            float z = (int)obj;
//            Console.WriteLine($"value:{z}\t type:{z.GetType()}");//20.floaT

//            var obj1 = x;
//            int a = obj1;
//            Console.WriteLine($"value:{obj1}\t type:{obj1.GetType()}");//20.int

//            var obj2 = new StringBuilder("string data");

//            dynamic d = x;
//            int b = d;
//            Console.WriteLine($"value:{d}\t type:{d.GetType()}");//20,int
//            */

//            int choice = 1;

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Once");
//                    break;

//                case 2:
//                    Console.WriteLine("Two");
//                    break;

//                default:
//                    Console.WriteLine("Invalid");
//                    break;
//            }

//        }
        
//    }
//}
