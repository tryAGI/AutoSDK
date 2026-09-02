# tryAGI.Extensions.HttpClientFactory

An intentionally small transport adapter that lets the Google APIs .NET SDK use
a named `IHttpClientFactory` pipeline. It is not an HTTP client or a generated
provider SDK: it only bridges Google's `Google.Apis.Http.IHttpClientFactory`
abstraction to the standard .NET factory.

## Google APIs

```csharp
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using tryAGI.Extensions.HttpClientFactory.Google;

var initializer = new BaseClientService.Initializer
{
    ApplicationName = "My application",
    HttpClientFactory = new GoogleHttpClientFactory(httpClientFactory, "GoogleCalendar"),
};
var calendar = new CalendarService(initializer);
```

The adapter defaults Google SDK retries to one attempt so the named client can
own resilience. Pass a different `numberOfTries` only when that is intentional.

Named clients continue to own DNS rotation, telemetry, resilience handlers,
proxies, and test transports. Provider credentials and product-level policy
remain application concerns.
