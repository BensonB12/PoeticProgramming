using FluentAssertions;
using TheMeatOfTheProgram.Sayings.Animals;

namespace Tests.Sayings;

/// <summary>
/// Italian Phrase
/// 1666 by Giovanni Torriano
/// </summary>
public class MakeNoiseOfTheEntity
{
  [Fact]
  public void MakeNoiseOfTheEntityAndItWillEmerge()
  {
    // Given
    Entity entity = new();

    // When
    entity.MakeNoise("... The Entity ...");

    // Then
    TheEntity.HasEmergedFor.Should().Contain(entity);
  }

  [Fact]
  public void DoNotMakeNoiseOfTheEntityAndItWillNotEmerge()
  {
    // Given
    Entity entity = new();

    // When
    entity.MakeNoise("... general Entity ...");

    // Then
    TheEntity.HasEmergedFor.Should().NotContain(entity);
  }

  [Fact]
  public void SpeakOfTheEntityInPossessionAndItWillEmerge()
  {
    // Given
    Entity entity = new();

    // When
    entity.MakeNoise("... The Entity's ...");

    // Then
    TheEntity.HasEmergedFor.Should().Contain(entity);
  }
}