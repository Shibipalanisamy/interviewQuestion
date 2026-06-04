using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using Partices.Basic;
using Partices.InterviewQuestion;

namespace Partices.Basic;


public class Tests
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("test value");
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

        A a= new B();
        a.test();
        B b = (B)a;
        b.test();
        
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
    [Test]
    public void test3()
    {
        SecondlargestDuplicateNumber S = new SecondlargestDuplicateNumber();
        S.sortnumber();

        int i = 10;
        var m= ExtensionMethodClass.ExtensionMethod(i);
        Console.WriteLine(m);
    }
    [Test]
    public void test4()
    {
        WebDriver driver = new EdgeDriver();
        driver.Url = "https://practice.expandtesting.com/";

        
        driver.SwitchTo().Window(driver.WindowHandles.Last());

        Console.WriteLine(driver.WindowHandles.Count());

        driver.Close();
    }
    [Test]
    public void test5()
    {StringsBasedQuestions st= new StringsBasedQuestions();
        st.DuplicateValue();
        
    }
}
