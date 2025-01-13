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
    var minFlapper = flappers.MinBy(b => b.TimeGotUp);

    minFlapper?.Eat(new Food());
  }


  /// <summary>
  /// Started English, now viewed as an American Idiom
  /// The newest 'American form' is being represented here
  /// Daniel Defoe in 1705
  /// </summary>
  public static void IfArticleIsTheSameSizeAsEntityThenEntityDonsArticle(Article article, ref Entity entity)
  {
    if (article.Size == entity.Size)
    {
      entity.Don(article);
    }
  }
}