using TheMeatOfTheProgram.Sayings.Animal;
using TheMeatOfTheProgram.Sayings.Item;
namespace TheMeatOfTheProgram.Sayings;

public class AbstractSayings
{
  /// <summary>
  /// English expression
  /// William Camden in 1605
  /// </summary>  
  public static void One()
  {
    List<ObjectForFirstSaying> somethings = [];

    var subject = somethings.MinBy(b => b.GetTimeGotUp);

    subject?.Eat(new Food());
  }


  /// <summary>
  /// American idiom
  /// Daniel Defoe 1705 (kind of)
  /// </summary>
  public static void Two()
  {
    SubjectForSecondSaying subject = new();
    ObjectForSecondSaying something = new();

    if (subject.Size == something.Size)
    {
      something.Don(subject);
    }
  }
}