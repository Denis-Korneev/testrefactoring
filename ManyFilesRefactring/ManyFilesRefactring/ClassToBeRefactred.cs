namespace ManyFilesRefactring
{
  public class ClassToBeRefactred
  {
    private int _x;

    public ClassToBeRefactred(int x)
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