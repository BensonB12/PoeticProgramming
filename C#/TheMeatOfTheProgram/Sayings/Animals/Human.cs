using System.Text.RegularExpressions;
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
    if (Regex.IsMatch(words, @"\bdevil('s|s|s')?\b", RegexOptions.IgnoreCase))
    {
      _speaksOfTheDevil?.Invoke(this);
    }
  }
}

public class Entity : Human
{
  delegate void NotifyEventHandler(Entity entity);
  event NotifyEventHandler _speaksOfTheEntity = delegate { };
  public int Size => ShoeSize;
  public Entity() : base()
  {
    initializeEntity();
  }
  public IEnumerable<ClothingItem> HasDonned => Clothing;
  public Entity(int size) : base(size)
  {
    initializeEntity();
  }
  void initializeEntity()
  {
    _speaksOfTheEntity += TheEntity.IsSpokenOf;
  }
  public void MakeNoise(string noise)
  {
    if (Regex.IsMatch(noise, @"\bthe entity('s|s|s')?\b", RegexOptions.IgnoreCase))
    {
      _speaksOfTheEntity?.Invoke(this);
    }
    Speak(noise);
  }
  public void Don(ClothingItem clothingItem)
  {
    Wear(clothingItem);
  }
}