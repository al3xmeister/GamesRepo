///Considerations
////To allow anonymous usage, allowAnonymous should be set to true in the project, then a call made to api/register/anonymous in order
///to be granted an API token intended for anonymous users, with therefore limited permissions
///To ensure scalablity, the request should be async and not depend on previous thread results for data entries
///In order to prevent a CSRF type exploit, send the token in a custom HTTP header, such as  headers: {'RequestVerificationToken': '@TokenHeaderValue()'}
///The controller class should dependency inject a latitude and longitude in order to reference previous values and have current ones readily available;
///The previous values should be checked and if same the cached, idempotent result should be retrieved
///A limit on the number of endpoint calls per second an ip address can make should be considered before/instead of allowing same ip to request multiple times;
///A service class should retrieve the apikey specific to the project once, instead of instantiating each time a post ocurrs
///Further consideration needs added to the view passing latitude, longitude as valid values
///A try/catch methodology is perhaps put to good use, alongside a log file to record any potential failures, or succesful results, alongside timestamp.


[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    double _latitude;
    double _longitude;
    double _result;

    public ValuesController(double latitude, double longitude)
    {
        _latitude = latitude;
        _longitude = _longitude;
    }

    // GET api/values/20.2/25.5
    [HttpGet]
    public async Task <ActionResult<double>> GetAverageTempAsync(double latitude, double longitude)
    {
        if (latitude != _latitude || longitude != _longitude)
        {
            var temperatures = new List<double>();
            var today = DateTime.Today;
            var apiKey = await AppService.GetApiKey();

            foreach (int i = 0; i > -5; i--) {
                var weatherDate = today.AddDays(i);
                var avgTemp = await this.PostCoordinatesAsync(latitude, longitude, weatherDate, apiKey);

                if (avgTemp != null)
                {
                    days.Add(avgTemp);
                }
            }

            _result = temperatures.Average();
        }
        else
        {
            return _result;
        }
    }

    // POST api/values
    [HttpPost]
    public async Task<double> PostCoordinatesAsync([FromBody] double lat, double lon, DateTime dt, Guid apiKey)
    {
        //retrieve json result
        //return "temp" key from json
    }
}

