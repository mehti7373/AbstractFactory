using AbstractFactory.Asia.Products;

namespace AbstractFactory.Asia;

/// <summary>
/// The 'ConcreteFactory1' class
/// </summary>
class ConcreteFactoryAsia : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new AsiaProductA();
    }
    public override AbstractProductB CreateProductB()
    {
        return new AsiaProductB();
    }
}
