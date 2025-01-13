using FluentAssertions;
using TheMeatOfTheProgram.Sayings.Animals;

namespace Tests.Sayings;

/// <summary>
/// The literal meaning is a superstition that if you speak of the Devil, he will show himself to you, implying bad things for you
/// The phrase implies a coincidence that someone has just joined (a) person/people right when they where talking about them
/// Started as "Talk of the Devil, and he's presently at your elbow"
/// Fun Fact is that it started as a very serous, stern warning, but now is more often used in a casual sense
/// Italian Phrase
/// 1666 by Giovanni Torriano
/// </summary>
public class SpeakOfTheDevil
{
  [Fact]
  public void SpeakOfTheDevilAndHeWillAppear()
  {
    // Given
    Human human = new();

    // When
    human.Speak("... devil ...");

    // Then
    Devil.HasAppearedTo.Should().Contain(human);
  }

  [Fact]
  public void DoNotSpeakOfTheDevilAndHeWillNotAppear()
  {
    // Given
    Human human = new();

    // When
    human.Speak("... daredevil ...");

    // Then
    Devil.HasAppearedTo.Should().NotContain(human);
  }

  [Fact]
  public void SpeakOfTheDevilInPossessionAndHeWillAppear()
  {
    // Given
    Human human = new();

    // When
    human.Speak("... Devil's ...");

    // Then
    Devil.HasAppearedTo.Should().Contain(human);
  }
}