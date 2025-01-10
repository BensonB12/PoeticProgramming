using FluentAssertions;
using TheMeatOfTheProgram.Sayings;
using TheMeatOfTheProgram.Sayings.Animals;

namespace Tests.Sayings.EarlyBird;

public class EarlyBird
{
  [Fact]
  public void OneBirdGetsTheWorm()
  {
    // Given
    Bird earlyBird = new(DateTime.Now);

    // When
    IEnumerable<Bird> birds = [earlyBird];
    Saying.EarlyBirdGetsTheWorm(ref birds);

    // Then
    earlyBird.EnergySources.Should().Contain(energySource => energySource is Worm);
  }

  [Fact]
  public void TheEarlierBirdGetsTheWorm()
  {
    // Given
    Bird earliestBird = new(DateTime.MinValue);
    Bird laterBird = new(DateTime.MaxValue);

    // When
    IEnumerable<Bird> birds = [earliestBird, laterBird];
    Saying.EarlyBirdGetsTheWorm(ref birds);

    // Then
    earliestBird.EnergySources.Should().Contain(energySource => energySource is Worm);
    laterBird.EnergySources.Should().BeEmpty();
  }

  [Fact]
  public void TheFirstEarlyBirdGetsTheWorm()
  {
    // Given
    Bird earlyInLineBird = new(DateTime.MinValue);
    Bird laterInLineBird = new(DateTime.MinValue);

    // When
    IEnumerable<Bird> birds = [earlyInLineBird, laterInLineBird];
    Saying.EarlyBirdGetsTheWorm(ref birds);

    // Then
    earlyInLineBird.EnergySources.Should().Contain(energySource => energySource is Worm);
    laterInLineBird.EnergySources.Should().BeEmpty();
  }
}