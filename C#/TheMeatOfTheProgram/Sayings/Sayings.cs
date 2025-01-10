using TheMeatOfTheProgram.Sayings.Animal;
using TheMeatOfTheProgram.Sayings.Item;
namespace TheMeatOfTheProgram.Sayings;

public class Sayings
{
  //////////
  public static void One()
  {
    List<ObjectForFirstSaying> somethings = [];

    var subject = somethings.MinBy(b => b.GetTimeGotUp);

    subject?.Eat(new Food());
  }


  public static void EarlyBirdGetsTheWorm()
  {
    List<Bird> allBirds = [];
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

  //////////

  public static void Two()
  {
    SubjectForSecondSaying subject = new();
    ObjectForSecondSaying something = new();

    if (subject.Size == something.Size)
    {
      something.Don(subject);
    }
  }

  public static void IfTheShoeFits()
  {
    Shoe shoe = new(1);
    Human human = new(1);

    if (shoe.Size == human.ShoeSize)
    {
      human.Wear(shoe);
    }
  }

  // IF THE SHOE FITS, WEAR IT
  // The literal meaning is that if a shoe you own fits your feet, you should be using it
  // The idiom implies that you should accept something as true if it applies to you (often a retort to criticism)
  // American Idiom
  // Daniel Defoe (Technically the author of 'cap fits' in england, but whatever)
  //////////
}