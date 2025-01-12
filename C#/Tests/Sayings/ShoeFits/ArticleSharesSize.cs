using FluentAssertions;
using TheMeatOfTheProgram.Sayings;
using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;

namespace Tests.Sayings;

public class ArticleSharesSize
{
  [Fact]
  public void TheShoeFitsSoTheyWearIt()
  {
    // Given
    int size = 1;
    Article article = new(size);
    Entity entity = new(size);

    // When
    AbstractSaying.IfArticleIsTheSameSizeAsEntityThenEntityDonsArticle(article, ref entity);

    // Then
    entity.HasDonned.Should().Contain(article);
  }

  [Fact]
  public void TheShoeDoesNotFitsSoTheyDoNotWearIt()
  {
    // Given
    Article article = new(0);
    Entity entity = new(1);

    // When
    AbstractSaying.IfArticleIsTheSameSizeAsEntityThenEntityDonsArticle(article, ref entity);

    // Then
    entity.HasDonned.Should().BeEmpty();
  }
}