using NUnit.Framework.Internal;
using Partices.Basic;
using Partices.InterviewQuestion;
namespace Partices.Basic;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        yieldPartices yo = new yieldPartices();
        yo.printallCountry();

        Animal animal= new Animal();
        animal.Eat();
        Dog dog= new Dog();
        dog.Eat();
        dog.bark();
        Animal an = new Dog();
        an.Eat();
        iAnimal animal1 = new Dog();
        animal1.sleep();

        BankAccount Bankbalance = new BankAccount(1000);
        Bankbalance.deposite = 100;
        Console.WriteLine(Bankbalance.deposite);
        }
    [Test]
    public void test2()
    {
        refandout refout=new refandout();
        int a = 10;
        int b = 5;

      int sumval=  refout.addnumber(ref a, out b);

        Console.WriteLine(sumval);
        Console.WriteLine(b);
        StartwithCharactor S= new StartwithCharactor();
        Console.WriteLine(S.ReturnValue<String>("M").First());
        S.LinqOnlyStartwithCharter();
        S.BasedONLenght();
        S.OrderByString();
     SecondlargestDuplicateNumber ss= new SecondlargestDuplicateNumber();
        ss.deuplicate();
        Console.WriteLine("----------- ----");
        ss.revwersetheString();
        Console.WriteLine("----------- ----");
        ss.splitVowles();
    }
}
