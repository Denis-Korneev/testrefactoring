namespace ManyFilesRefactring
{
  public class ClassXx
  {
    public ClassXx()
    {
      var x = new ClassToRefactor2(1);
    }
  }

  public class Class1
  {
    public Class1()
    {
      var x = new ClassToRefactor2(1);
      var y = new ClassXx();
    }
  }
}