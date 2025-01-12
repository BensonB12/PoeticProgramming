using TheMeatOfTheProgram.Sayings.Animals.Exertions;

namespace TheMeatOfTheProgram.Sayings.Animals;


public class Bird : Animal
{
  IEnumerable<Type> _birdConsumables = [typeof(Worm), typeof(Food)];
  DateTime _timeGotUp;
  public DateTime TimeGotUp => _timeGotUp;
  IEnumerable<EnergySource> _energySources = [];
  public IEnumerable<EnergySource> EnergySources => _energySources;
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
    else
    {
      _energySources = _energySources.Append(food);
    }
  }

  bool isConsumable(EnergySource food)
  {
    return _birdConsumables.Contains(food.GetType());
  }
}

public class Flapper(DateTime timeGotUp) : Bird(timeGotUp) { }