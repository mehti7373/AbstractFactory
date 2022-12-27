using AbstractFactory.America.Products;

namespace AbstractFactory.America;

/// <summary>
/// The 'ConcreteFactory2' class
/// </summary>
class ConcreteFactoryAmerica : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new AmericaProductA();
    }
    public override AbstractProductB CreateProductB()   
    {
        return new AmericaProductB();
    }
}