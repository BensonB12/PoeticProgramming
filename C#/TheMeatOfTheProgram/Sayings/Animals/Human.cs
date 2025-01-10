using System.IO.Compression;
using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;

public class Human : Animal
{
  int _shoeSize;
  public int ShoeSize => _shoeSize;

  public Human(int shoeSize)
  {
    _shoeSize = shoeSize;
  }

  public void Wear(Clothing clothing) { }
}

public class Entity : Human
{
  public Entity() : base(0) { }

  public int Size => ShoeSize;

  public void Don(Clothing clothing)
  {
    Wear(clothing);
  }
}