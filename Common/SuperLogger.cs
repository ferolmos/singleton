
namespace Common
{
  public class SuperLogger: ILogger
  {
    private string _key;

    public SuperLogger()
    {
      this._key = "InitialValue";
    }

    public void SetKey(string value)
    {
      this._key = value;
    }

    public void Log(string message)
    {
      System.Diagnostics.Debug.WriteLine($"{message} with key value: {this._key}");
    }
  }
}
