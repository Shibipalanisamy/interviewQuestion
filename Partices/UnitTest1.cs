using Partices.Basic;
namespace Partices
{
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

            

        }
    }
}
