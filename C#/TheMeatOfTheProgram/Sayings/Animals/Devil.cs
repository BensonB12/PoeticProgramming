namespace TheMeatOfTheProgram.Sayings.Animals;

public static class Devil
{
  static IEnumerable<Human> _hasAppearedTo = [];
  public static IEnumerable<Human> HasAppearedTo => _hasAppearedTo;

  public static void IsSpokenOf(Human human)
  {
    _hasAppearedTo = _hasAppearedTo.Append(human);
  }
}