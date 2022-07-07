using System;

namespace Operator_overloading__Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit, Explicit
            //Manat manat = new Manat(200);

            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);

            //string name = "123E";
            //Console.WriteLine(int.Parse(name).GetType());

            //int age = 77;
            //Console.WriteLine(age.ToString().GetType());

            //DateTime date = DateTime.Now;
            //var result = date.ToString("MM/dd/yyyy");
            //Console.WriteLine(result);

            //var n = Convert.ToInt32(name);
            //Console.WriteLine(n);
            #endregion

            #region Generics
            //StringList list = new StringList();

            //list.Add("Orxan");
            //list.Add("Ayxan");

            //list.GetAll();

            //IntList list1 = new IntList();

            //list1.Add(5);
            //list1.Add(10);
            //list1.Add(100);

            //list1.GetAll();

            //BookList bookList = new BookList();

            //Book book1 = new Book
            //{
            //    Name = "Leyli ve Mecnun",
            //    Author = "Nizami"
            //};

            //Book book2 = new Book
            //{
            //    Name = "7 gozel",
            //    Author = "Nizami"
            //};

            //Book book3 = new Book
            //{
            //    Name = "1984",
            //    Author = "Goerge"
            //};

            //bookList.Add(book1);
            //bookList.Add(book2);
            //bookList.Add(book3);

            //bookList.GetAll();

            //DataList<string> stringList = new DataList<string>();

            //stringList.Add("Emil");
            //stringList.Add("Nermin");
            //stringList.Add("Fidan");
            //stringList.Add("Seadet");

            //stringList.GetAll();

            //DataList<int> intList = new DataList<int>();

            //intList.Add(5);
            //intList.Add(10);
            //intList.Add(15);
            //intList.Add(20);

            //intList.GetAll();

            //DataList<Book> bookList = new DataList<Book>();

            //bookList.Add(new Book { Author = "Cavid", Name = "Programlashdirma" });

            //bookList.GetAll();

            //Employee<string> emp1 = new Employee<string>();

            //Employee<int> emp2 = new Employee<int>();

            //Employee<Person> emp3 = new Employee<Person>();

            //Employee<Person, Common> employee = new Employee<Person, Common>();
            #endregion

            #region Operator overloading
            //Employee employee = new Employee("Orxan", 27);
            //Student student = new Student("Emil", 20);

            //Console.WriteLine(employee > student);
            #endregion
        }
    }

    #region Implicit, Explicit
    //public class Dollar
    //{
    //    public double Usd { get; set; }
    //    public Dollar(double usd)
    //    {
    //        Usd = usd;  
    //    }
    //}
    //public class Manat
    //{
    //    public double Azn { get; set; }
    //    public  Manat(double azn)
    //    {
    //        Azn = azn;
    //    }
    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar(manat.Azn / 1.7);
    //    }
    //}
    #endregion

    #region Generics
    //public class Employee<T, U> where T : class
    //                            where T : struct
    //                            where T : Common
    //                            where T : ITest
    //                            where T : new()
    //                            where T : U
    //{

    //}

    //public class Person : Common
    //{

    //}

    //public abstract class Common
    //{

    //}

    //public class Test
    //{

    //}

    //public interface ITest
    //{

    //}

    //public class DataList<T>
    //{
    //    private T[] arr;

    //    public DataList()
    //    {
    //        arr = new T[0];
    //    }

    //    public void Add(T data)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //public class IntList
    //{
    //    private int[] arr;

    //    public IntList()
    //    {
    //        arr = new int[0];
    //    }

    //    public void Add(int m)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = m;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //public class BookList
    //{
    //    private Book[] arr;

    //    public BookList()
    //    {
    //        arr = new Book[0];
    //    }

    //    public void Add(Book book)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = book;
    //    }

    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item.Name + " - " + item.Author);
    //        }
    //    }
    //}

    //public class Book
    //{
    //    public string Name { get; set; }
    //    public string Author { get; set; }
    //}
    #endregion

    #region Operator overloading
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Student(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Employee(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public static bool operator >(Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }

    //    public static bool operator <(Employee employee, Student student)
    //    {
    //        return employee.Age < student.Age;
    //    }
    //}
    #endregion
}