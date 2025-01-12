using System.IO.Compression;
using TheMeatOfTheProgram.Sayings.Items;

namespace TheMeatOfTheProgram.Sayings.Animals;

public class Human : Animal
{
  int _shoeSize;
  public int ShoeSize => _shoeSize;
  IEnumerable<ClothingItem> _clothing = [];
  public IEnumerable<ClothingItem> Clothing => _clothing;
  const int _defaultShoeSize = 1;
  delegate void NotifyEventHandler(Human human);
  event NotifyEventHandler _speaksOfTheDevil = delegate { };

  public Human()
  {
    initializeHuman();
  }

  public Human(int shoeSize)
  {
    initializeHuman(shoeSize);
  }

  void initializeHuman(int shoeSize = _defaultShoeSize)
  {
    _shoeSize = shoeSize;
    _speaksOfTheDevil += Devil.IsSpokenOf;
  }

  public void Wear(ClothingItem clothingItem)
  {
    _clothing = _clothing.Append(clothingItem);
  }

  public void Speak(string words)
  {
    if (words.Contains("devil", StringComparison.OrdinalIgnoreCase))
    {
      _speaksOfTheDevil?.Invoke(this);
    }
  }
}

public class Entity : Human
{
  public int Size => ShoeSize;
  public IEnumerable<ClothingItem> HasDonned => Clothing;
  public Entity(int size) : base(size) { }

  public void Don(ClothingItem clothingItem)
  {
    Wear(clothingItem);
  }
}