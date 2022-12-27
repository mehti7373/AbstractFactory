using AbstractFactory.America;
using AbstractFactory.Asia;

namespace AbstractFactory;
/// <summary>
/// MainApp startup class for Structural
/// Abstract Factory Design Pattern.
/// </summary>
class MainApp
{
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public static void Main()
    {
        // Abstract factory #Asia
        AbstractFactory factoryAsia = new ConcreteFactoryAsia();
        Client clientAsia = new Client(factoryAsia);
        clientAsia.Run();
        // Abstract factory #America
        AbstractFactory factoryAmerica = new ConcreteFactoryAmerica();
        Client clientAmerica = new Client(factoryAmerica);
        clientAmerica.Run();
        // Wait for user input
        Console.ReadKey();
    }
}