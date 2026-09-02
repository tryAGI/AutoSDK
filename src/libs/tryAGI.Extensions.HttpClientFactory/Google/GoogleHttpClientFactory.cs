using Google.Apis.Http;

namespace tryAGI.Extensions.HttpClientFactory.Google;

/// <summary>
/// Adapts a named <see cref="System.Net.Http.IHttpClientFactory"/> client to the Google API .NET SDK.
/// </summary>
public sealed class GoogleHttpClientFactory : global::Google.Apis.Http.IHttpClientFactory
{
    private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
    private readonly string _clientName;
    private readonly int _numberOfTries;

    /// <summary>
    /// Initializes a Google SDK transport backed by a named <see cref="HttpClient"/>.
    /// </summary>
    /// <param name="httpClientFactory">The application HTTP client factory.</param>
    /// <param name="clientName">The configured named client.</param>
    /// <param name="numberOfTries">
    /// The Google handler attempt count. Use <c>1</c> when resilience is owned by the named client.
    /// </param>
    public GoogleHttpClientFactory(
        System.Net.Http.IHttpClientFactory httpClientFactory,
        string clientName,
        int numberOfTries = 1)
    {
        ArgumentNullException.ThrowIfNull(httpClientFactory);
        ArgumentException.ThrowIfNullOrWhiteSpace(clientName);
        ArgumentOutOfRangeException.ThrowIfLessThan(numberOfTries, 1);

        _httpClientFactory = httpClientFactory;
        _clientName = clientName;
        _numberOfTries = numberOfTries;
    }

    /// <inheritdoc />
    public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
    {
        ArgumentNullException.ThrowIfNull(args);

#pragma warning disable CA2000 // The returned ConfigurableHttpClient owns the complete handler chain.
        var configurableHandler = new ConfigurableMessageHandler(
            new NamedHttpClientMessageHandler(_httpClientFactory, _clientName))
        {
            ApplicationName = args.ApplicationName,
            GoogleApiClientHeader = args.GoogleApiClientHeader,
            UniverseDomain = args.UniverseDomain,
            NumTries = _numberOfTries,
        };
        var client = new ConfigurableHttpClient(configurableHandler);
#pragma warning restore CA2000
        foreach (var initializer in args.Initializers)
        {
            initializer.Initialize(client);
        }

        return client;
    }
}
