namespace TheMeatOfTheProgram.Sayings.Item;

public class Shoe : Clothing
{
  int _size;
  public int Size => _size;

  public Shoe(int size)
  {
    _size = size;
  }
}

public class SubjectForSecondSaying : Shoe
{
  public SubjectForSecondSaying() : base(0) { }
}