using TheMeatOfTheProgram.Sayings.Animal;
namespace TheMeatOfTheProgram.Sayings;

public class Sayings
{
  //////////

  public static void EarlyBirdGetsTheWorm()
  {
    List<Bird> allBirds = [new(DateTime.Now)];
    Worm worm = new();

    Bird? earliestBird = allBirds.MinBy(bird => bird.GetTimeGotUp);

    earliestBird?.Eat(worm);
  }

  // THE EARLY BIRD GETS THE WORM
  // The literal meaning is that the birds who get up the earliest have a better chance of getting worms because there are no other birds competing for the worms
  // The expression implies that people who arrive first have better chance of success
  // English expression
  // William Camden in 1605
  //////////
}