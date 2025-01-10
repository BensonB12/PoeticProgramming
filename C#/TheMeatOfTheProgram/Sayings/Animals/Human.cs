using System.IO.Compression;
using TheMeatOfTheProgram.Sayings.Animal;
using TheMeatOfTheProgram.Sayings.Item;

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

public class ObjectForSecondSaying : Human
{
  public ObjectForSecondSaying() : base(0) { }

  public int Size => ShoeSize;

  public void Don(Clothing clothing)
  {
    Wear(clothing);
  }
}