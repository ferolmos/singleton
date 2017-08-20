namespace Common
{
  public interface ILogger
  {
    void SetKey(string value);
    void Log(string message);
  }
}