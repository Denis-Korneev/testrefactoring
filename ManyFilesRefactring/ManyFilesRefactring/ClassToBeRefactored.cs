namespace ManyFilesRefactring
{
  public class ClassToRefactor
  {
    private int _x;

    public ClassToRefactor(int x)
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