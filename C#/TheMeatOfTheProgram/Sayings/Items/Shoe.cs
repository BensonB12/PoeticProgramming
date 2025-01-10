namespace TheMeatOfTheProgram.Sayings.Items;

public class Shoe : Clothing
{
  int _size;
  public int Size => _size;

  public Shoe(int size)
  {
    _size = size;
  }
}

public class Article : Shoe
{
  public Article() : base(0) { }
}