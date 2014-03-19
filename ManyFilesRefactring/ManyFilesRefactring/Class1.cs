namespace ManyFilesRefactring
{
  public class Class1
  {
    public Class1()
    {
      var x = new ClassToRefactor2(1);
    }
  }

  public class ClassXX
  {
    public ClassXX()
    {
      var x = new ClassToRefactor2(1);
    }
  }
}