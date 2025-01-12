using FluentAssertions;
using TheMeatOfTheProgram.Sayings.Animals;

namespace Tests.Sayings;

public class SpeakOfTheDevil
{
  [Fact]
  public void SpeakOfTheDevilAndHeWillAppear()
  {
    // Given
    Human human = new();

    // When
    human.Speak("devil");

    // Then
    Devil.HasAppearedTo.Should().Contain(human);
  }
}