using System.Web.Http;
using Common;

namespace WebAppCheckStatic.Controllers
{
  public class PepeController : ApiController
  {
    private readonly ILogger _logger;

    public PepeController(ILogger logger)
    {
      this._logger = logger;
    }


    [Route("api/pepe/customers/{customerId}")]
    public void GetOne(int customerId)
    {
      _logger.SetKey($"CallWithID {customerId}");

      _logger.Log(string.Empty);
    }

    [Route("api/pepe/orders/{orderId}")]
    public void GetTwo(int orderId)
    {
      _logger.Log(string.Empty);
    }

  }
}
