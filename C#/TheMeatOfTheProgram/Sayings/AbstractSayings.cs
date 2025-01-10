using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;
namespace TheMeatOfTheProgram.Sayings;

public static class AbstractSaying
{
  /// <summary>
  /// English expression
  /// William Camden in 1605
  /// </summary>  
  public static void AFlapperEats(ref IEnumerable<Flapper> flappers)
  {
    var subject = flappers.MinBy(b => b.TimeGotUp);

    subject?.Eat(new Food());
  }


  /// <summary>
  /// American idiom
  /// Daniel Defoe 1705 (kind of)
  /// </summary>
  public static void IfArticleIsTheSameSizeAsEntityThenEntityDonsArticle(Article article, ref Entity entity)
  {
    if (article.Size == entity.Size)
    {
      entity.Don(article);
    }
  }
}