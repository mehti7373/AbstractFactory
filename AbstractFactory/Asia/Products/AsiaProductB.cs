namespace AbstractFactory.Asia.Products;

/// <summary>
/// The 'ProductB1' class
/// </summary>
class AsiaProductB : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}
