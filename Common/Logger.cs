
namespace Common
{
  
  public class Logger : ILogger
  {
    private static Logger logger;

    private string key;

    private Logger()
    {

    }

    public static Logger GetLogger()
    {
      return logger ?? (logger = new Logger());
    }


    public void SetKey(string value)
    {
      this.key = value;
    }

    public void Log(string message)
    {
      System.Diagnostics.Debug.WriteLine($"{message} with key value: {logger.key}");
    }
  }
}
