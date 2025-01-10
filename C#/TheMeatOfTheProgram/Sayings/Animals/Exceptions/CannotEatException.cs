namespace TheMeatOfTheProgram.Sayings.Animals.Exertions;

public class CannotEatException : Exception
{
  public string Animal { get; }
  public string Food { get; }

  public CannotEatException(string animal, string food)
      : base($"{animal} cannot eat {food}.")
  {
    Animal = animal;
    Food = food;
  }

  public CannotEatException(string message, string animal, string food)
      : base(message)
  {
    Animal = animal;
    Food = food;
  }
}