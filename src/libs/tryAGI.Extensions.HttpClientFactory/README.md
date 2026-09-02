# tryAGI.Extensions.HttpClientFactory

Reusable adapters that let official provider SDKs use named
`IHttpClientFactory` pipelines without duplicating request forwarding code in
each application.

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

## Octokit

```csharp
using Octokit;
using tryAGI.Extensions.HttpClientFactory.Octokit;

var github = httpClientFactory.CreateOctokitClient(
    "GitHub",
    new ProductHeaderValue("my-application"));
github.Credentials = new Credentials(token, AuthenticationType.Bearer);

using var request = github.BeginRequestScope(cancellationToken);
var issue = await github.Issue.Get("owner", "repository", 42);
```

`BeginRequestScope` flows cancellation through high-level Octokit methods that
do not expose a `CancellationToken`. The scope is async-flow-local and supports
nesting, so concurrent operations can use different tokens safely.

Named clients continue to own DNS rotation, telemetry, resilience handlers,
proxies, and test transports. Provider credentials and product-level policy
remain application concerns.
