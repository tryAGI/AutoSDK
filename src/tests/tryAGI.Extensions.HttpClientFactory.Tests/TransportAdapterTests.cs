using System.Net;
using System.Text;
using AwesomeAssertions;
using Google.Apis.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Octokit;
using tryAGI.Extensions.HttpClientFactory.Google;
using tryAGI.Extensions.HttpClientFactory.Octokit;

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

    [TestMethod]
    public async Task OctokitAdapter_UsesNamedClientAndCredentials()
    {
        var handler = new RecordingHandler(_ => JsonResponse("{\"id\":1,\"name\":\"repo\",\"full_name\":\"owner/repo\",\"owner\":{\"login\":\"owner\",\"id\":2},\"private\":false,\"html_url\":\"https://github.com/owner/repo\",\"url\":\"https://api.github.com/repos/owner/repo\"}"));
        var factory = new RecordingHttpClientFactory(handler);
        var client = factory.CreateOctokitClient("github", new ProductHeaderValue("tryAGI-tests"));
        client.Credentials = new Credentials("secret", AuthenticationType.Bearer);

        var repository = await client.Repository.Get("owner", "repo");

        repository.FullName.Should().Be("owner/repo");
        factory.Names.Should().Equal("github");
        handler.Requests.Should().ContainSingle();
        handler.Requests[0].Authorization.Should().Be("Bearer secret");
    }

    [TestMethod]
    public async Task OctokitRequestScope_CancelsHighLevelOperationTransport()
    {
        var handler = new RecordingHandler(async (_, cancellationToken) =>
        {
            await Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken);
            return JsonResponse("{}");
        });
        var factory = new RecordingHttpClientFactory(handler);
        var client = factory.CreateOctokitClient("github", new ProductHeaderValue("tryAGI-tests"));
        using var cancellation = new CancellationTokenSource();
        using var requestScope = client.BeginRequestScope(cancellation.Token);

        var request = client.Repository.Get("owner", "repo");
        await cancellation.CancelAsync();

        await request.Invoking(static task => task).Should().ThrowAsync<OperationCanceledException>();
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
