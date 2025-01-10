using FluentAssertions;
using TheMeatOfTheProgram.Sayings;
using TheMeatOfTheProgram.Sayings.Animals;

namespace Tests.Sayings.EarlyBird;

public class AbstractEarlyBird
{
  [Fact]
  public void OneFlapper()
  {
    // Given
    Flapper flapper = new(DateTime.Now);

    // When
    IEnumerable<Flapper> flappers = [flapper];
    AbstractSaying.AFlapperEats(ref flappers);

    // Then
    flapper.EnergySources.Should().Contain(energySource => energySource is Food);
  }

  [Fact]
  public void TwoFlappersAtDifferentTimes()
  {
    // Given
    Flapper flapper1 = new(DateTime.MinValue);
    Flapper flapper2 = new(DateTime.MaxValue);

    // When
    IEnumerable<Flapper> flappers = [flapper1, flapper2];
    AbstractSaying.AFlapperEats(ref flappers);

    // Then
    flapper1.EnergySources.Should().Contain(energySource => energySource is Food);
    flapper2.EnergySources.Should().BeEmpty();
  }

  [Fact]
  public void TwoFlappersAtTheSameTime()
  {
    // Given
    Flapper flapper1 = new(DateTime.MinValue);
    Flapper flapper2 = new(DateTime.MinValue);

    // When
    IEnumerable<Flapper> flappers = [flapper1, flapper2];
    AbstractSaying.AFlapperEats(ref flappers);

    // Then
    flapper1.EnergySources.Should().Contain(energySource => energySource is Food);
    flapper2.EnergySources.Should().BeEmpty();
  }
}