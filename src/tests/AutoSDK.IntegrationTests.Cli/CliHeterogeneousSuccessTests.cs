using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliHeterogeneousSuccessTests
{
    [TestMethod]
    public async Task Generate_HeterogeneousSuccess_CompilesAndDispatchesActualRuntimeOutcome()
    {
        var repository = FindRepository();
        var output = Path.Combine(Path.GetTempPath(), "autosdk-success-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            await RunAsync(repository, "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI", "--",
                "generate", Path.Combine(repository, "specs/heterogeneous-success.yaml"),
                "--namespace", "AudioContract", "--clientClassName", "AudioClient",
                "--targetFramework", "net10.0", "--output", output);
            var methods = Directory.GetFiles(output, "*AudioClient.StreamOrQueue*.g.cs");
            methods.Should().HaveCount(2, "only the client and interface should be emitted, without media variants");
            await File.WriteAllTextAsync(Path.Combine(output, "Runtime.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                  </PropertyGroup>
                </Project>
                """);
            await File.WriteAllTextAsync(Path.Combine(output, "Program.cs"), Runtime);
            await RunAsync(output, "run", "--disable-build-servers", "--no-launch-profile", "--project", "Runtime.csproj");
        }
        finally
        {
            Directory.Delete(output, recursive: true);
        }
    }

    private static string FindRepository()
    {
        for (var directory = new DirectoryInfo(AppContext.BaseDirectory); directory != null; directory = directory.Parent)
        {
            if (File.Exists(Path.Combine(directory.FullName, "AutoSDK.slnx")))
            {
                return directory.FullName;
            }
        }
        throw new InvalidOperationException("AutoSDK repository was not found.");
    }

    private static async Task RunAsync(string directory, params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = directory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };
        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }
        process.Start();
        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(3));
        var stdout = process.StandardOutput.ReadToEndAsync(timeout.Token);
        var stderr = process.StandardError.ReadToEndAsync(timeout.Token);
        string messages;
        try
        {
            await process.WaitForExitAsync(timeout.Token);
            // A child retaining a redirected pipe must not outlive the timeout either.
            messages = await stdout.WaitAsync(timeout.Token) + await stderr.WaitAsync(timeout.Token);
        }
        catch
        {
            if (!process.HasExited)
            {
                process.Kill(entireProcessTree: true);
            }
            throw;
        }
        process.ExitCode.Should().Be(0, messages);
    }

    private const string Runtime = """
        using System.Net;
        using System.Net.Http.Headers;
        using AudioContract;

        static void Check(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        foreach (var mediaType in new[] { "audio/wav", "audio/ogg" })
        {
            var bytes = new byte[] { 0, 255, 128, 195, 40, 1 };
            var stream = new TrackedStream(bytes);
            var handler = new Handler(HttpStatusCode.OK, new StreamContent(stream), mediaType);
            using var http = new HttpClient(handler);
            using var client = new AudioClient(http, new Uri("https://fixture.invalid"));
            using (var result = await client.StreamOrQueueAsync())
            {
                Check(result.StatusCode == HttpStatusCode.OK && result.Body202 == null, "binary discriminant");
                Check(result.Headers["x-fixture"].Single() == "present", "response headers");
                Check(result.Headers["Content-Type"].Single().StartsWith(mediaType), "content headers");
                Check(result.RequestUri == new Uri("https://fixture.invalid/mixed"), "request URI");
                Check(!stream.Disposed, "binary stream must remain readable after return");
                using var copy = new MemoryStream();
                await result.Body200!.CopyToAsync(copy);
                Check(copy.ToArray().SequenceEqual(bytes), "exact non-UTF8 bytes");
            }
            Check(stream.Disposed && handler.Count == 1, "binary ownership and request count");
        }

        foreach (var wrapped in new[] { false, true })
        {
            var stream = new TrackedStream(System.Text.Encoding.UTF8.GetBytes("{\"id\":\"queued-123\"}"));
            var handler = new Handler(HttpStatusCode.Accepted, new StreamContent(stream), "application/json");
            using var http = new HttpClient(handler);
            using var client = new AudioClient(http, new Uri("https://fixture.invalid"));
            using var result = wrapped
                ? (await client.StreamOrQueueAsResponseAsync()).Body
                : await client.StreamOrQueueAsync();
            Check(result.StatusCode == HttpStatusCode.Accepted && result.Body200 == null, "JSON discriminant");
            Check(result.Body202?.Id == "queued-123", "queued JSON model");
            Check(stream.Disposed && handler.Count == 1, "JSON ownership and request count");
        }

        // The wrapper's binary body has the same explicit ownership as the regular result.
        {
            var stream = new TrackedStream([255]);
            var handler = new Handler(HttpStatusCode.OK, new StreamContent(stream), "audio/wav");
            using var http = new HttpClient(handler);
            using var client = new AudioClient(http, new Uri("https://fixture.invalid"));
            var wrapper = await client.StreamOrQueueAsResponseAsync();
            Check(wrapper.StatusCode == HttpStatusCode.OK && !stream.Disposed, "wrapped binary ownership");
            wrapper.Body.Dispose();
            Check(stream.Disposed && handler.Count == 1, "wrapped binary disposal");
        }

        foreach (var binary in new[] { false, true })
        {
            var stream = new BlockingStream();
            var handler = new Handler(binary ? HttpStatusCode.OK : HttpStatusCode.Accepted,
                new StreamContent(stream), binary ? "audio/wav" : "application/json");
            using var http = new HttpClient(handler);
            using var client = new AudioClient(http, new Uri("https://fixture.invalid"));
            using var cancellation = new CancellationTokenSource();
            AudioClient.StreamOrQueueResult? result = null;
            async Task ReadAsync()
            {
                result = await client.StreamOrQueueAsync(cancellationToken: cancellation.Token);
                if (binary) await result.Body200!.ReadExactlyAsync(new byte[1], cancellation.Token);
            }
            var read = ReadAsync();
            await stream.Started.Task.WaitAsync(TimeSpan.FromSeconds(5));
            cancellation.Cancel();
            try
            {
                await read;
                throw new InvalidOperationException("read did not cancel");
            }
            catch (OperationCanceledException) { }
            finally { result?.Dispose(); }
            Check(stream.Disposed && handler.Count == 1, "canceled body ownership and request count");
        }

        foreach (var (status, mediaType) in new[]
        {
            (HttpStatusCode.InternalServerError, "text/plain"),
            (HttpStatusCode.OK, "application/json"),
            (HttpStatusCode.Accepted, "audio/wav"),
            (HttpStatusCode.NonAuthoritativeInformation, "audio/wav"),
        })
        {
            var stream = new TrackedStream(System.Text.Encoding.UTF8.GetBytes("failure"));
            var handler = new Handler(status, new StreamContent(stream), mediaType);
            using var http = new HttpClient(handler);
            using var client = new AudioClient(http, new Uri("https://fixture.invalid"));
            try
            {
                await client.StreamOrQueueAsync();
                throw new InvalidOperationException("unexpected contract accepted");
            }
            catch (ApiException exception)
            {
                Check(exception.StatusCode == status, "failure status");
                Check(exception.ResponseHeaders!["x-fixture"].Single() == "present", "failure headers");
                if (status == HttpStatusCode.InternalServerError)
                    Check(exception.ResponseBody == "failure", "failure body");
            }
            Check(stream.Disposed && handler.Count == 1, "failure ownership and request count");
        }
        Console.WriteLine("Heterogeneous success runtime regression passed.");

        sealed class Handler(HttpStatusCode status, HttpContent content, string mediaType) : HttpMessageHandler
        {
            public int Count { get; private set; }
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Count++;
                content.Headers.ContentType = MediaTypeHeaderValue.Parse(mediaType + "; charset=utf-8");
                var response = new HttpResponseMessage(status) { Content = content, RequestMessage = request };
                response.Headers.Add("x-fixture", "present");
                return Task.FromResult(response);
            }
        }

        class TrackedStream(byte[] bytes) : MemoryStream(bytes)
        {
            public bool Disposed { get; private set; }
            protected override void Dispose(bool disposing) { Disposed = true; base.Dispose(disposing); }
        }

        sealed class BlockingStream() : TrackedStream([])
        {
            public TaskCompletionSource Started { get; } = new(TaskCreationOptions.RunContinuationsAsynchronously);
            public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
            {
                Started.TrySetResult();
                await Task.Delay(Timeout.Infinite, cancellationToken);
                return 0;
            }
            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) =>
                await ReadAsync(buffer.AsMemory(offset, count), cancellationToken);
        }
        """;
}
