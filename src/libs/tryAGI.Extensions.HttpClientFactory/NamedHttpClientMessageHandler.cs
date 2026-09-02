namespace tryAGI.Extensions.HttpClientFactory;

internal sealed class NamedHttpClientMessageHandler(
    IHttpClientFactory httpClientFactory,
    string clientName) : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        using var forwardedRequest = await CloneAsync(request, cancellationToken).ConfigureAwait(false);
        using var client = httpClientFactory.CreateClient(clientName);
        return await client.SendAsync(
                forwardedRequest,
                HttpCompletionOption.ResponseHeadersRead,
                cancellationToken)
            .ConfigureAwait(false);
    }

    private static async Task<HttpRequestMessage> CloneAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var clone = new HttpRequestMessage(request.Method, request.RequestUri)
        {
            Version = request.Version,
            VersionPolicy = request.VersionPolicy,
        };

        foreach (var header in request.Headers)
        {
            clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        if (request.Content is not null)
        {
            var content = new MemoryStream();
            await request.Content.CopyToAsync(content, cancellationToken).ConfigureAwait(false);
            content.Position = 0;
            clone.Content = new StreamContent(content);
            foreach (var header in request.Content.Headers)
            {
                clone.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }

        return clone;
    }
}
