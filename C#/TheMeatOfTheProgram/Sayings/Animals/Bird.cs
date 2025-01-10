using TheMeatOfTheProgram.Sayings.Animal.Exertions;

namespace TheMeatOfTheProgram.Sayings.Animal;


public class Bird : Animal
{
  List<Type> _birdConsumables = [typeof(Worm)];
  DateTime _timeGotUp;
  public DateTime GetTimeGotUp => _timeGotUp;
  public Bird() { }
  public Bird(DateTime timeGotUp)
  {
    _timeGotUp = timeGotUp;
  }

  public void Eat(EnergySource food)
  {
    if (!isConsumable(food))
    {
      throw new CannotEatException("bird", food.GetType().Name);
    }
  }

  bool isConsumable(EnergySource food)
  {
    return _birdConsumables.Contains(food.GetType());
  }
}

public class ObjectForFirstSaying : Bird { }