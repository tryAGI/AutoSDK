using Octokit;
using Octokit.Internal;

namespace tryAGI.Extensions.HttpClientFactory.Octokit;

/// <summary>
/// Creates Octokit REST clients that use an application's named <see cref="HttpClient"/> pipeline.
/// </summary>
public static class OctokitHttpClientFactoryExtensions
{
    /// <summary>
    /// Creates an Octokit client backed by the named client. Credentials may be replaced per
    /// operation through <see cref="GitHubClient.Credentials"/>.
    /// </summary>
    public static GitHubClient CreateOctokitClient(
        this IHttpClientFactory httpClientFactory,
        string clientName,
        ProductHeaderValue productHeader)
    {
        ArgumentNullException.ThrowIfNull(httpClientFactory);
        ArgumentException.ThrowIfNullOrWhiteSpace(clientName);
        ArgumentNullException.ThrowIfNull(productHeader);

#pragma warning disable CA2000 // Octokit owns the adapter for the lifetime of the returned client connection.
        var adapter = new HttpClientAdapter(
            () => new NamedHttpClientMessageHandler(httpClientFactory, clientName));
        var client = new GitHubClient(new Connection(productHeader, adapter));
#pragma warning restore CA2000
        return client;
    }
}
