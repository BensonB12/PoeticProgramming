using FluentAssertions;
using TheMeatOfTheProgram.Sayings;
using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;

namespace Tests.Sayings;

public class ShoeFits
{
  [Fact]
  public void TheShoeFitsSoTheyWearIt()
  {
    // Given
    int size = 1;
    Shoe shoe = new(size);
    Human human = new(size);

    // When
    Saying.IfTheShoeFitsWearIt(shoe, ref human);

    // Then
    human.Clothing.Should().Contain(shoe);
  }

  [Fact]
  public void TheShoeDoesNotFitsSoTheyDoNotWearIt()
  {
    // Given
    Shoe shoe = new(0);
    Human human = new(1);

    // When
    Saying.IfTheShoeFitsWearIt(shoe, ref human);

    // Then
    human.Clothing.Should().BeEmpty();
  }
}