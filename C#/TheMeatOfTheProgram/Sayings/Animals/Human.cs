using System.IO.Compression;
using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;

public class Human : Animal
{
  int _shoeSize;
  public int ShoeSize => _shoeSize;
  List<ClothingItem> _clothing = new();
  public List<ClothingItem> Clothing => _clothing;

  public Human(int shoeSize)
  {
    _shoeSize = shoeSize;
  }

  public void Wear(ClothingItem clothingItem)
  {
    _clothing.Add(clothingItem);
  }
}

public class Entity : Human
{
  public int Size => ShoeSize;
  public List<ClothingItem> HasDonned => Clothing;
  public Entity(int size) : base(size) { }

  public void Don(ClothingItem clothingItem)
  {
    Wear(clothingItem);
  }
}