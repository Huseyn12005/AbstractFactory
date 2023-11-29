namespace AbstractFactory
{
    interface IChair
    {
        void SitOn();
    }

    interface ISofa
    {
        void LayOn();
    }

    interface ICoffeeTable
    {
        void DrinkCoffe();
    }

    // Concrete Product Classes
    class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on an Art Deco chair");
        }
    }

    class VictorianChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian chair");
        }
    }

    class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern chair");
        }
    }

    class ArtDecoSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("laying on an Art Deco sofa");
        }
    }

    class VictorianSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Victorian sofa");
        }
    }

    class ModernSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Modern sofa");
        }
    }

    class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Art Deco coffee table");
        }
    }

    class VictorianCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Victorian coffee table");
        }
    }

    class ModernCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Modern coffee table");
        }
    }

    // Abstract Factory Interface
    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }

    // Concrete Factory Classes
    class ArtDecoFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }

    class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }

    class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    // Client Code
    class Client
    {
        public void CreateFurniture(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var coffeeTable = factory.CreateCoffeeTable();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            IFurnitureFactory artDecoFactory = new ArtDecoFactory();
            client.CreateFurniture(artDecoFactory);

            IFurnitureFactory victorianFactory = new VictorianFactory();
            client.CreateFurniture(victorianFactory);

            IFurnitureFactory modernFactory = new ModernFactory();
            client.CreateFurniture(modernFactory);
        }
    }
}