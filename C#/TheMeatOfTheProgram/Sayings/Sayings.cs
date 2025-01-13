using TheMeatOfTheProgram.Sayings.Animals;
using TheMeatOfTheProgram.Sayings.Items;
namespace TheMeatOfTheProgram.Sayings;

public static class Saying
{
  /// <summary>
  /// THE EARLY BIRD GETS THE WORM
  /// The literal meaning is that the birds who get up the earliest have a better chance of getting worms because there are no other birds competing for the worms
  /// The expression implies that people who arrive first have better chance of success
  /// English expression
  /// William Camden in 1605
  /// </summary>
  public static void EarlyBirdGetsTheWorm(ref IEnumerable<Bird> birds)
  {
    Bird? earliestBird = birds.MinBy(bird => bird.TimeGotUp);

    earliestBird?.Eat(new Worm());
  }


  /// <summary>
  /// IF THE SHOE FITS, WEAR IT
  /// The literal meaning is that if a shoe you own fits your feet, you should be using it
  /// The idiom implies that you should accept something as true if it applies to you (often a retort to criticism)
  /// Originally started as "Gentlemen, and if the Cap fits any Body let 'em wear it"
  /// Started English, now viewed as an American Idiom
  /// Daniel Defoe in 1705
  /// </summary>
  public static void IfTheShoeFitsWearIt(Shoe shoe, ref Human human)
  {
    if (shoe.Size == human.ShoeSize)
    {
      human.Wear(shoe);
    }
  }
}