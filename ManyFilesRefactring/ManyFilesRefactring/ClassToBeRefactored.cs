namespace ManyFilesRefactring
{
  public class ClassToBeRefactored
  {
    private int _x;

    public ClassToBeRefactored(int x)
    {
      _x = x;
    }

    public int X
    {
      get { return _x; }
      set { _x = value; }
    }

  }
}