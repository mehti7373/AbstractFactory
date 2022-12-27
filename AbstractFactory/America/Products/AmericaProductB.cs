namespace AbstractFactory.America.Products;

/// <summary>
/// The 'ProductB2' class
/// </summary>
class AmericaProductB : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}
