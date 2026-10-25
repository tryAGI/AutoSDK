using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliStreamResponseTests
{
    [TestMethod]
    public async Task Generate_BinaryStreamResponse_ExposesMetadataBeforeBodyAndOwnsLifetime()
    {
        var repository = FindRepository();
        var output = Path.Combine(Path.GetTempPath(), "autosdk-stream-response-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(output);
        try
        {
            var spec = Path.Combine(output, "fixture.yaml");
            await File.WriteAllTextAsync(spec, Spec);
            await RunAsync(repository, "run", "--disable-build-servers", "--no-launch-profile", "--project", "src/libs/AutoSDK.CLI", "--",
                "generate", spec, "--namespace", "FileContract", "--clientClassName", "FileClient",
                "--targetFramework", "net10.0", "--output", output);
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

    private const string Spec = """
        openapi: 3.0.3
        info:
          title: File response fixture
          version: '1'
        paths:
          /download:
            get:
              operationId: downloadFile
              responses:
                '200':
                  description: File
                  headers:
                    Content-Disposition:
                      schema: { type: string }
                    Content-Length:
                      schema: { type: integer }
                    ETag:
                      schema: { type: string }
                  content:
                    '*/*':
                      schema: { type: string, format: binary }
                '206':
                  description: Selected byte range
                  headers:
                    Content-Range:
                      schema: { type: string }
                  content:
                    '*/*':
                      schema: { type: string, format: binary }
                '304':
                  description: Not modified
                '416':
                  description: Range not satisfiable
        """;

    private const string Runtime = """
        using System.Net;
        using System.Net.Http.Headers;
        using FileContract;

        static void Check(bool condition, string message)
        {
            if (!condition) throw new InvalidOperationException(message);
        }

        foreach (var status in new[] { HttpStatusCode.OK, HttpStatusCode.PartialContent })
        foreach (var asyncDispose in new[] { false, true })
        {
            var stream = new SuspendedStream();
            var handler = new Handler(status, new StreamContent(stream));
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            IFileClient api = client;
            var result = await api.DownloadFileAsStreamAsResponseAsync(
                requestOptions: new AutoSDKRequestOptions { Headers = { ["Range"] = "bytes=0-5" } })
                .WaitAsync(TimeSpan.FromSeconds(5));
            Check(result.StatusCode == status, "actual status");
            Check(result.Headers["Content-Disposition"].Single() == "attachment; filename=fixture.bin", "filename");
            Check(result.Headers["Content-Length"].Single() == "6", "length before read");
            Check(result.Headers["Content-Type"].Single() == "application/x-fixture", "arbitrary MIME");
            Check(result.Headers["Content-Range"].Single() == "bytes 0-5/10", "range metadata");
            Check(result.Headers["ETag"].Single() == "\"fixture\"", "ETag");
            Check(result.RequestUri == new Uri("https://cdn.invalid/final"), "final request URI");
            Check(stream.Reads == 0 && stream.Disposals == 0, "metadata available before first byte");
            Check(handler.Range == "bytes=0-5" && handler.Count == 1, "single range request");
            // Reject based on metadata without ever releasing the suspended body.
            if (asyncDispose) await result.Body.DisposeAsync();
            else result.Body.Dispose();
            result.Body.Dispose();
            Check(handler.Response!.Disposals == 1 && stream.Disposals > 0 && stream.Reads == 0, "early rejection releases the response exactly once");
        }

        foreach (var legacyRead in new[] { false, true })
        {
            var stream = new SuspendedStream();
            var handler = new Handler(HttpStatusCode.OK, new StreamContent(stream));
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            var result = await client.DownloadFileAsStreamAsResponseAsync();
            using var cancellation = new CancellationTokenSource();
            var read = legacyRead
                ? result.Body.ReadAsync(new byte[1], 0, 1, cancellation.Token)
                : result.Body.ReadAsync(new byte[1].AsMemory(), cancellation.Token).AsTask();
            await stream.Started.Task.WaitAsync(TimeSpan.FromSeconds(5));
            cancellation.Cancel();
            try
            {
                await read;
                throw new InvalidOperationException("read did not cancel");
            }
            catch (OperationCanceledException) { }
            Check(handler.Response!.Disposals == 1 && stream.Disposals > 0, "canceled read releases response without caller cleanup");
            result.Body.Dispose();
            Check(handler.Response.Disposals == 1, "disposal after cancellation is idempotent");
        }

        foreach (var readKind in new[] { "sync", "array", "memory" })
        {
            var stream = new FaultingStream();
            var handler = new Handler(HttpStatusCode.OK, new StreamContent(stream));
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            var result = await client.DownloadFileAsStreamAsResponseAsync();
            try
            {
                var count = readKind switch
                {
                    "sync" => result.Body.Read(new byte[1], 0, 1),
                    "array" => await result.Body.ReadAsync(new byte[1], 0, 1),
                    _ => await result.Body.ReadAsync(new byte[1].AsMemory()),
                };
                throw new InvalidOperationException("read failure lost; returned byte count: " + count);
            }
            catch (IOException) { }
            Check(handler.Response!.Disposals == 1 && stream.Disposals > 0, "failed read releases response: " + readKind);
        }

        {
            var content = new CancelOnOpenContent();
            var handler = new Handler(HttpStatusCode.OK, content);
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            try
            {
                await client.DownloadFileAsStreamAsResponseAsync();
                throw new InvalidOperationException("stream acquisition did not cancel");
            }
            catch (OperationCanceledException) { }
            Check(handler.Response!.Disposals == 1 && content.Disposed, "canceled stream acquisition releases response");
        }

        var bytes = new byte[] { 0, 255, 128, 195, 40, 1 };
        foreach (var variant in new[] { "stream-response", "stream", "bytes", "bytes-response", "conditional" })
        {
            var stream = new TrackedStream(bytes);
            var handler = new Handler(HttpStatusCode.PartialContent, new StreamContent(stream));
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            byte[] actual;
            if (variant == "bytes") actual = await client.DownloadFileAsync();
            else if (variant == "bytes-response") actual = (await client.DownloadFileAsResponseAsync()).Body;
            else
            {
                Stream body;
                if (variant == "stream") body = await client.DownloadFileAsStreamAsync();
                else if (variant == "conditional")
                {
                    var conditional = await AutoSDKConditionalRequests.SendAsync<Stream>(
                        (options, token) => client.DownloadFileAsStreamAsResponseAsync(requestOptions: options, cancellationToken: token),
                        entityTag: "\"cached\"");
                    Check(!conditional.NotModified && conditional.Response!.StatusCode == HttpStatusCode.PartialContent, "conditional 206");
                    body = conditional.Response!.Body;
                }
                else body = (await client.DownloadFileAsStreamAsResponseAsync()).Body;
                await using (body)
                {
                    using var copy = new MemoryStream();
                    await body.CopyToAsync(copy);
                    actual = copy.ToArray();
                }
            }
            Check(actual.SequenceEqual(bytes), "exact non-UTF8 bytes: " + variant);
            Check(handler.Count == 1 && handler.Response!.Disposals == 1 && stream.Disposals > 0, "ownership: " + variant);
        }

        foreach (var status in new[] { HttpStatusCode.NotModified, HttpStatusCode.RequestedRangeNotSatisfiable })
        {
            var stream = new TrackedStream([]);
            var handler = new Handler(status, new StreamContent(stream));
            using var http = new HttpClient(handler);
            using var client = new FileClient(http, new Uri("https://fixture.invalid"));
            if (status == HttpStatusCode.NotModified)
            {
                var result = await AutoSDKConditionalRequests.SendAsync<Stream>(
                    (options, token) => client.DownloadFileAsStreamAsResponseAsync(requestOptions: options, cancellationToken: token),
                    entityTag: "\"cached\"");
                Check(result.NotModified && result.Response == null && result.EntityTag == "\"fixture\"", "conditional 304");
                Check(handler.EntityTag == "\"cached\"", "conditional request header");
            }
            else
            {
                try
                {
                    await client.DownloadFileAsStreamAsResponseAsync();
                    throw new InvalidOperationException("416 accepted");
                }
                catch (ApiException exception) { Check(exception.StatusCode == status, "failure status"); }
            }
            Check(handler.Count == 1 && handler.Response!.Disposals == 1 && stream.Disposals > 0, "error disposal");
        }
        Console.WriteLine("Stream response runtime regression passed.");

        sealed class Handler(HttpStatusCode status, HttpContent content) : HttpMessageHandler
        {
            public int Count { get; private set; }
            public string? Range { get; private set; }
            public string? EntityTag { get; private set; }
            public TrackedResponse? Response { get; private set; }
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Count++;
                Range = request.Headers.Range?.ToString();
                EntityTag = request.Headers.IfNoneMatch.FirstOrDefault()?.ToString();
                request.RequestUri = new Uri("https://cdn.invalid/final");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-fixture");
                content.Headers.ContentLength = 6;
                content.Headers.TryAddWithoutValidation("Content-Disposition", "attachment; filename=fixture.bin");
                content.Headers.TryAddWithoutValidation("Content-Range", "bytes 0-5/10");
                Response = new TrackedResponse(status) { Content = content, RequestMessage = request };
                Response.Headers.ETag = new EntityTagHeaderValue("\"fixture\"");
                return Task.FromResult<HttpResponseMessage>(Response);
            }
        }

        sealed class TrackedResponse(HttpStatusCode status) : HttpResponseMessage(status)
        {
            public int Disposals { get; private set; }
            protected override void Dispose(bool disposing)
            {
                if (disposing) Disposals++;
                base.Dispose(disposing);
            }
        }

        class TrackedStream(byte[] bytes) : MemoryStream(bytes)
        {
            public int Disposals { get; private set; }
            protected override void Dispose(bool disposing)
            {
                if (disposing) Disposals++;
                base.Dispose(disposing);
            }
        }

        sealed class FaultingStream() : TrackedStream([])
        {
            public override int Read(byte[] buffer, int offset, int count) => throw new IOException("fixture");
            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken token) =>
                Task.FromException<int>(new IOException("fixture"));
            public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default) =>
                ValueTask.FromException<int>(new IOException("fixture"));
        }

        sealed class CancelOnOpenContent : HttpContent
        {
            public bool Disposed { get; private set; }
            protected override Task<Stream> CreateContentReadStreamAsync() =>
                Task.FromCanceled<Stream>(new CancellationToken(true));
            protected override Task<Stream> CreateContentReadStreamAsync(CancellationToken token) =>
                Task.FromCanceled<Stream>(new CancellationToken(true));
            protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context) => Task.CompletedTask;
            protected override bool TryComputeLength(out long length) { length = 0; return true; }
            protected override void Dispose(bool disposing) { Disposed |= disposing; base.Dispose(disposing); }
        }

        sealed class SuspendedStream : Stream
        {
            public int Reads { get; private set; }
            public int Disposals { get; private set; }
            public TaskCompletionSource Started { get; } = new(TaskCreationOptions.RunContinuationsAsynchronously);
            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
            public override int Read(byte[] buffer, int offset, int count) => throw new InvalidOperationException("unexpected sync read");
            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken token) =>
                ReadAsync(buffer.AsMemory(offset, count), token).AsTask();
            public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
            {
                Reads++;
                Started.TrySetResult();
                await Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken);
                return 0;
            }
            protected override void Dispose(bool disposing)
            {
                if (disposing) Disposals++;
                base.Dispose(disposing);
            }
            public override void Flush() => throw new NotSupportedException();
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }
        """;
}
