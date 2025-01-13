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

  [Fact]
  public void DoNotSpeakOfTheDevilAndHeWillNotAppear()
  {
    // Given
    Human human = new();
    Devil.ResetHasAppearedTo();

    // When
    human.Speak("daredevil");

    // Then
    Devil.HasAppearedTo.Should().BeEmpty();
  }

  [Fact]
  public void SpeakOfTheDevilInPluralAndHeWillAppear()
  {
    // Given
    Human human = new();

    // When
    human.Speak("devils");

    var humans = Devil.HasAppearedTo;
    // Then
    Devil.HasAppearedTo.Should().Contain(human);
  }
}