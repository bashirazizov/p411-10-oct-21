using System;
using System.Net.Mail;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //string[] strs = { "123", "446" };
            //string[] strs2 = new string[2];
            //strs[0] = "asd";
            //Array.Resize(ref strs, strs.Length+1);
            //strs[2] = "asd";
            //strs[5] = "asd";
            //Console.WriteLine(strs[2]);


            //string names = "Bashir, Mamed, Ilkin";
            //string[] arr = names.Split(", ");
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Interface
            //IWithdrawable wthdrbl = new Account();
            //wthdrbl.Withdraw(10);

            //Account a = new Account();
            //a.x = 10;
            //a.SumXandY();

            //Person p1 = new Person("Mamed", "Aliyev", 19);
            //Person p2 = new Person("Kamran", "Mammadov", 21);
            //Person p3 = new Person("Orkhan", "Qurbanli", 18);

            //Person[] people = { p1, p2, p3 };

            //try
            //{
            //    Array.Sort(people);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Gonderdiyin array sort oluna bilmir.");
            //}

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region CompareTo
            //int a = 10;
            //int b = int.Parse(Console.ReadLine());
            //int result = a.CompareTo(b);

            //Console.WriteLine(a.CompareTo(4));
            //Console.WriteLine(a.CompareTo(10));
            //Console.WriteLine(a.CompareTo(20));
            #endregion

            #region Enum
            //User user = new User();
            //user.VerificationStatus = 0;
            //user.VerifyEmail();
            //user.VerifyPhone();

            //if (user.VerificationStatus==0)
            //{
            //    Console.WriteLine("Cant use any functionality.");
            //}
            //else if(user.VerificationStatus == 1)
            //{
            //    Console.WriteLine("Can use some functionality.");
            //}
            //else
            //{
            //    Console.WriteLine("Can use all functionality.");
            //}


            //User user = new User();
            //user.status = UserStatus.Inactive;

            //if (user.status == UserStatus.Inactive)
            //{
            //    Console.WriteLine("Cant use any functionality.");
            //}
            //else if (user.status == UserStatus.EmailVerified)
            //{
            //    Console.WriteLine("Can use some functionality.");
            //}
            //else if(user.status == UserStatus.Active)
            //{
            //    Console.WriteLine("Can use all functionality.");
            //}

            //Console.WriteLine((int)UserStatus.Active);

            //Console.Write("1 le 4 arasinda reqem secin. Uygun fesil gelecek.");
            //int selection;
            //try
            //{

            //    selection = int.Parse(Console.ReadLine());

            //    switch (selection)
            //    {
            //        case (int)Seasons.Winter:
            //            Console.WriteLine("Hava Soyuqdur");
            //            break;

            //        case (int)Seasons.Spring:
            //            Console.WriteLine("Hava Qizir");
            //            break;

            //        case (int)Seasons.Summer:
            //            Console.WriteLine("Hava Istidir");
            //            break;

            //        case (int)Seasons.Fall:
            //            Console.WriteLine("Hava Soyuyur");
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Problem oldu.");
            //}


            //int selection;
            //if (int.TryParse(Console.ReadLine(), out selection))
            //{
            //    switch (selection)
            //    {
            //        case (byte)Seasons.Winter:
            //            Console.WriteLine("Hava Soyuqdur");
            //            break;

            //        case (byte)Seasons.Spring:
            //            Console.WriteLine("Hava Qizir");
            //            break;

            //        case (byte)Seasons.Summer:
            //            Console.WriteLine("Hava Istidir");
            //            break;

            //        case (byte)Seasons.Fall:
            //            Console.WriteLine("Hava Soyuyur");
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Parse eleye biledim");
            //}
            #endregion

            #region Extension
            //while (true)
            //{
            //    Console.Write("Email Adresinizi daxil edin: ");
            //    string email = Console.ReadLine();
            //    if (email.isValidEmail())
            //    {
            //        Console.WriteLine(email+" duzgun maildir");
            //    }
            //    else
            //    {
            //        Console.WriteLine(email + " duzgun maildeyil");
            //    }
            //}

            //int num = 100;
            //Console.WriteLine(num.Sum(10));
            #endregion

            #region Struct
            //Cube c1 = new Cube();
            //Cube c2 = new Cube(1,2,3);

            //c1.X = 10;
            //c1.Y = 10;
            //c1.Z = 10;
            #endregion
        }
    }

    #region Struct
    //struct Cube
    //{
    //    public Cube(int x, int y, int z)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }

    //    public int X;
    //    public int Y;
    //    public int Z;

    //    public int getVolume()
    //    {
    //        return X * Y * Z;
    //    }
    //}
    #endregion

    #region Enum
    //enum Seasons:byte
    //{
    //    Winter=1, Spring, Summer, Fall
    //}
    ////enum Weekdays
    ////{
    ////    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    ////}

    //enum UserStatus : byte
    //{
    //    Inactive=1, EmailVerified, Active
    //}

    //class User
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public string Email { get; set; }
    //    public string Phone { get; set; }

    //    public UserStatus status;

    //    //public byte VerificationStatus { get; set; }

    //    //public void VerifyEmail()
    //    //{
    //    //    VerificationStatus = 1;
    //    //}

    //    //public void VerifyPhone()
    //    //{
    //    //    VerificationStatus = 2;
    //    //}
    //}
    #endregion

    #region Interface
    //abstract class Vehicle
    //{ }


    //class Car : Vehicle, IMovable
    //{
    //    public void Move()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Student : Person, IMovable
    //{
    //    public void Move()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Person : IComparable
    //{
    //    public string Name { get; set; }
    //    public string SurName { get; set; }
    //    public int Age { get; set; }

    //    public Person()
    //    { }

    //    public Person(string name, string surname, int age)
    //    {
    //        Name = name;
    //        SurName = surname;
    //        Age = age;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} {SurName} {Age}";
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        return Age.CompareTo(((Person)obj).Age);

    //        //Person personToCompare = (Person)obj;
    //        //if (Name.Length > personToCompare.Name.Length)
    //        //{
    //        //    return 1;
    //        //}
    //        //else if (Name.Length == personToCompare.Name.Length)
    //        //{
    //        //    if (Age > personToCompare.Age)
    //        //    {
    //        //        return 1;
    //        //    }
    //        //    else if (Age == personToCompare.Age)
    //        //    {
    //        //        return 0;
    //        //    }
    //        //    else
    //        //    {
    //        //        return -1;
    //        //    }
    //        //}
    //        //else
    //        //{
    //        //    return -1;
    //        //}
    //    }
    //}


    //abstract class Test
    //{
    //    public int x { get; set; }
    //    public int y { get; set; }

    //    public void SumXandY()
    //    {
    //        Console.WriteLine(x+y);
    //    }
    //}

    //class Account : Test, IWithdrawable, IBalancable
    //{
    //    public string PersonName { get; set; }
    //    public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Withdraw(double amount)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //class Cart : IWithdrawable, IBalancable
    //{
    //    public double Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void Withdraw(double amount)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //interface IWithdrawable
    //{
    //    void Withdraw(double amount);
    //}

    //interface IBalancable
    //{
    //    public double Balance { get; set; }
    //}
    #endregion
}
