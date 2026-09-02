using System.Net;
using System.Text;
using AwesomeAssertions;
using Google.Apis.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tryAGI.Extensions.HttpClientFactory.Google;

namespace tryAGI.Extensions.HttpClientFactory.Tests;

[TestClass]
public sealed class TransportAdapterTests
{
    [TestMethod]
    public async Task GoogleAdapter_UsesNamedClientAndPreservesRequest()
    {
        var handler = new RecordingHandler(_ => JsonResponse("{\"ok\":true}"));
        var factory = new RecordingHttpClientFactory(handler);
        var adapter = new GoogleHttpClientFactory(factory, "google", numberOfTries: 1);
        using var client = adapter.CreateHttpClient(new CreateHttpClientArgs
        {
            ApplicationName = "tests",
            GoogleApiClientHeader = "gl-test/1.0",
        });

        using var response = await client.PostAsync(
            "https://example.test/v1/resources",
            new StringContent("{\"name\":\"value\"}", Encoding.UTF8, "application/json"));

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        factory.Names.Should().Equal("google");
        handler.Requests.Should().ContainSingle();
        handler.Requests[0].Method.Should().Be(HttpMethod.Post);
        handler.Requests[0].Body.Should().Be("{\"name\":\"value\"}");
    }

    private static HttpResponseMessage JsonResponse(string json) => new(HttpStatusCode.OK)
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json"),
    };

    private sealed class RecordingHttpClientFactory(HttpMessageHandler handler) : System.Net.Http.IHttpClientFactory
    {
        public List<string> Names { get; } = [];

        public HttpClient CreateClient(string name)
        {
            Names.Add(name);
            return new HttpClient(handler, disposeHandler: false);
        }
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _responseFactory;

        public RecordingHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
            : this((request, _) => Task.FromResult(responseFactory(request)))
        {
        }

        public RecordingHandler(
            Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> responseFactory)
        {
            _responseFactory = responseFactory;
        }

        public List<RecordedRequest> Requests { get; } = [];

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Requests.Add(new RecordedRequest(
                request.Method,
                request.Headers.Authorization?.ToString(),
                request.Content is null
                    ? null
                    : await request.Content.ReadAsStringAsync(cancellationToken)));
            return await _responseFactory(request, cancellationToken);
        }
    }

    private sealed record RecordedRequest(HttpMethod Method, string? Authorization, string? Body);
}
