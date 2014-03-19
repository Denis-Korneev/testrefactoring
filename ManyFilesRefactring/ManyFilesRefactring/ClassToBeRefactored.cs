namespace ManyFilesRefactring
{
  public class ClassToRefactor2
  {
    private int _x;

    public ClassToRefactor2(int x)
    {
      _x = x;
    }

    public int X
    {
      get
      {
        return _x;
      }
      set
      {
        _x = value;
      }
    }

  }
}