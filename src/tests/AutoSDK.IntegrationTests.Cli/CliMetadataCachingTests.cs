using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace AutoSDK.IntegrationTests;

public partial class CliTests
{
    private const string MetadataCachingSpec = """
openapi: 3.0.3
info:
  title: Options-bound metadata cache
  version: 1.0.0
servers:
  - url: https://example.test
paths:
  /envelopes:
    post:
      operationId: echoEnvelopes
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: array
              items:
                $ref: '#/components/schemas/Envelope'
      responses:
        '200':
          description: Echo
          content:
            application/json:
              schema:
                type: array
                items:
                  $ref: '#/components/schemas/Envelope'
components:
  schemas:
    Envelope:
      type: object
      properties:
        text:
          type: string
        flag:
          type: boolean
        count:
          type: integer
        mode:
          type: string
          enum: [one, two]
        next:
          $ref: '#/components/schemas/Envelope'
        choice:
          oneOf:
            - $ref: '#/components/schemas/Cat'
            - $ref: '#/components/schemas/Dog'
          discriminator:
            propertyName: type
            mapping:
              cat: '#/components/schemas/Cat'
              dog: '#/components/schemas/Dog'
    EnvelopeUnused:
      type: object
      properties:
        never:
          type: string
    Cat:
      type: object
      required: [type]
      properties:
        type:
          type: string
          enum: [cat]
        name:
          type: string
    Dog:
      type: object
      required: [type]
      properties:
        type:
          type: string
          enum: [dog]
        bark:
          type: boolean
""";

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Generate_SharedMetadataCache_RespectsOptionsConcurrencyAndCycles(bool nativeAot)
    {
        await GenerateFromContentAsync("metadata-cache.yaml", MetadataCachingSpec,
            targetFramework: "net10.0", clientClassName: "CachingClient",
            additionalArguments: ["--shared-json-metadata"],
            assertBuiltOutput: async directory =>
            {
                var manifest = await File.ReadAllTextAsync(Directory.GetFiles(
                    directory, "*.autosdk-json-metadata", SearchOption.AllDirectories).Single());
                var envelopeBatch = manifest.Split('\n').Single(static line =>
                    line.StartsWith("// AutoSDK.JsonMetadata factory-batch:", StringComparison.Ordinal) &&
                    line.Split('|')[2].Split(',').Contains("Envelope", StringComparer.Ordinal));
                envelopeBatch.Split('|')[2].Split(',').Should().Contain("EnvelopeUnused",
                    "the trimming fixture must exercise unused factories inside the live batch");
                await File.WriteAllTextAsync(Path.Combine(directory, "ProbeContext.cs"), MetadataProbeContext);
                var projectPath = Path.Combine(directory, "Oag.csproj");
                var project = (await File.ReadAllTextAsync(projectPath)).Replace("</Project>",
                    "<PropertyGroup><IsTrimmable>true</IsTrimmable></PropertyGroup><ItemGroup><Compile Remove=\"Consumers/**/*.cs\" /></ItemGroup></Project>",
                    StringComparison.Ordinal);
                await File.WriteAllTextAsync(projectPath, project);
                var consumer = Path.Combine(directory, "Consumers", "cache");
                Directory.CreateDirectory(consumer);
                await File.WriteAllTextAsync(Path.Combine(consumer, "Probe.csproj"), $$"""
<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
<TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType><ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable><TreatWarningsAsErrors>true</TreatWarningsAsErrors>
<PublishTrimmed>true</PublishTrimmed><TrimMode>full</TrimMode><SelfContained>true</SelfContained>
<PublishAot>{{nativeAot.ToString().ToLowerInvariant()}}</PublishAot><PublishReadyToRun>false</PublishReadyToRun>
<TrimmerSingleWarn>false</TrimmerSingleWarn><SuppressTrimAnalysisWarnings>false</SuppressTrimAnalysisWarnings>
<JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
</PropertyGroup>
<ItemGroup><ProjectReference Include="../../Oag.csproj" /></ItemGroup>
</Project>
""");
                await File.WriteAllTextAsync(Path.Combine(consumer, "Program.cs"), MetadataCacheProgram);
                var publish = Path.Combine(consumer, "publish");
                var result = await RunDotnetAsync(consumer, "publish", "Probe.csproj", "-c", "Release",
                    "-r", RuntimeInformation.RuntimeIdentifier, "-o", publish);
                result.ExitCode.Should().Be(0, result.StandardOutput + result.StandardError);
                var run = await RunProcessAsync(Path.Combine(publish, OperatingSystem.IsWindows() ? "Probe.exe" : "Probe"), publish);
                Console.WriteLine(run.StandardOutput);
                run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
                run.StandardOutput.Should().Contain("metadata-cache-contract-passed")
                    .And.Contain("warm-lookups=0");
                if (!nativeAot)
                {
                    await VerifyUnusedBatchedMetadataAsync(directory, Path.Combine(consumer, "Probe.csproj"));
                }
            });
    }

    private static async Task VerifyUnusedBatchedMetadataAsync(string directory, string templateProject)
    {
        // The cache probe deliberately supplies an aggregate caller context, which retains
        // the full graph. Verify pruning independently through the normal default model scope.
        var consumer = Path.Combine(directory, "Consumers", "pruning");
        Directory.CreateDirectory(consumer);
        await File.WriteAllTextAsync(Path.Combine(consumer, "Pruning.csproj"), await File.ReadAllTextAsync(templateProject));
        await File.WriteAllTextAsync(Path.Combine(consumer, "Program.cs"), """"
using Oag;
var model = Envelope.FromJson("""{"text":"first","next":{"text":"child"},"choice":{"type":"cat","name":"m"}}""");
if (model?.Next?.Text != "child" || !model.ToJson().Contains("child", StringComparison.Ordinal)) return 2;
Console.WriteLine("batched-pruning-contract-passed");
return 0;
"""");
        var publish = Path.Combine(consumer, "publish");
        var result = await RunDotnetAsync(consumer, "publish", "Pruning.csproj", "-c", "Release",
            "-r", RuntimeInformation.RuntimeIdentifier, "-o", publish);
        result.ExitCode.Should().Be(0, result.StandardOutput + result.StandardError);
        using (var linkedStream = File.OpenRead(Path.Combine(publish, "Oag.dll")))
        using (var pe = new PEReader(linkedStream))
        {
            var metadata = pe.GetMetadataReader();
            metadata.TypeDefinitions.Select(handle => metadata.GetString(metadata.GetTypeDefinition(handle).Name))
                .Should().NotContain("EnvelopeUnused");
            metadata.MethodDefinitions.Select(handle => metadata.GetString(metadata.GetMethodDefinition(handle).Name))
                .Should().NotContain("Create_EnvelopeUnused");
        }
        var run = await RunProcessAsync(Path.Combine(publish, OperatingSystem.IsWindows() ? "Pruning.exe" : "Pruning"), publish);
        Console.WriteLine(run.StandardOutput);
        run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
        run.StandardOutput.Should().Contain("batched-pruning-contract-passed");
    }

    private const string MetadataProbeContext = """
namespace Oag;
public sealed partial class SourceGenerationContext
{
    /// <summary>Creates an instrumented, options-bound context for this fixture.</summary>
    /// <param name="options">The caller's options.</param>
    /// <param name="onResolve">Observes actual metadata resolution.</param>
    /// <returns>The instrumented context.</returns>
    public static System.Text.Json.Serialization.JsonSerializerContext CreateProbeForTests(
        System.Text.Json.JsonSerializerOptions options, System.Action<System.Type> onResolve)
    {
        System.ArgumentNullException.ThrowIfNull(options);
        System.ArgumentNullException.ThrowIfNull(onResolve);
        AddConverters(options);
        return new ProbeContext(options, onResolve);
    }
    private sealed class ProbeContext(
        System.Text.Json.JsonSerializerOptions options, System.Action<System.Type> onResolve)
        : System.Text.Json.Serialization.JsonSerializerContext(options)
    {
        protected override System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => Options;
        public override System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(System.Type type)
        {
            onResolve(type);
            return TypeInfoResolver.GetTypeInfo(type, Options);
        }
    }
}
""";

    private const string MetadataCacheProgram = """
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Oag;

const string json = "{\"text\":\"first\",\"flag\":true,\"count\":3,\"mode\":\"one\",\"choice\":{\"type\":\"cat\",\"name\":\"m\"},\"next\":{\"text\":\"child\",\"flag\":false}}";
var lookups = 0;
var context = SourceGenerationContext.CreateProbeForTests(new JsonSerializerOptions(),
    _ => Interlocked.Increment(ref lookups));
var clock = Stopwatch.StartNew();
var first = Envelope.FromJson(json, context) ?? throw new InvalidOperationException("Missing envelope.");
Check(first.Text == "first" && first.Next?.Text == "child", "Nested payload failed.");
Check(first.ToJson(context).Contains("\"m\"", StringComparison.Ordinal), "Polymorphic payload failed.");
var coldMilliseconds = clock.Elapsed.TotalMilliseconds;
var coldLookups = Volatile.Read(ref lookups);
var before = GC.GetAllocatedBytesForCurrentThread();
clock.Restart();
for (var iteration = 0; iteration < 1000; iteration++)
{
    var model = Envelope.FromJson(json, context) ?? throw new InvalidOperationException("Missing warm envelope.");
    Check(model.ToJson(context).Contains("first", StringComparison.Ordinal), "Warm round trip failed.");
}
var warmMilliseconds = clock.Elapsed.TotalMilliseconds;
var allocated = GC.GetAllocatedBytesForCurrentThread() - before;
var warmLookups = Volatile.Read(ref lookups) - coldLookups;
Console.WriteLine($"cache-probe cold-lookups={coldLookups} warm-lookups={warmLookups} cold-ms={coldMilliseconds:F3} warm-1000-ms={warmMilliseconds:F3} allocated-bytes={allocated}");
Check(warmLookups == 0, "Warm model helpers rebuilt metadata.");

using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
{
    var model = await Envelope.FromJsonStreamAsync(stream, context);
    Check(model?.Text == "first", "Stream helper failed.");
}
Check(Volatile.Read(ref lookups) == coldLookups, "Stream helper bypassed metadata caching.");
Check(Envelope.FromJson(json)?.Next?.Text == "child", "Default scope failed.");

var insensitive = SourceGenerationContext.CreateProbeForTests(
    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }, _ => { });
var strict = SourceGenerationContext.CreateProbeForTests(
    new JsonSerializerOptions { PropertyNameCaseInsensitive = false }, _ => { });
Check(Envelope.FromJson("{\"TEXT\":\"upper\"}", insensitive)?.Text == "upper", "Caller case options were ignored.");
Check(Envelope.FromJson("{\"TEXT\":\"upper\"}", strict)?.Text is null, "Metadata escaped its options lifetime.");

var convertedOptions = new JsonSerializerOptions();
convertedOptions.Converters.Add(new YesNoBooleanConverter());
var converted = SourceGenerationContext.CreateProbeForTests(convertedOptions, _ => { });
var convertedModel = Envelope.FromJson("{\"flag\":\"yes\"}", converted);
Check(convertedModel?.Flag == true && convertedModel.ToJson(converted).Contains("\"yes\"", StringComparison.Ordinal),
    "Caller converter was ignored.");
var nullable = Envelope.FromJson("{\"flag\":null,\"count\":null}", converted);
Check(nullable?.Flag is null && nullable?.Count is null, "Nullable metadata failed.");

var cyclicContext = SourceGenerationContext.CreateProbeForTests(
    new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles }, _ => { });
var cyclic = Envelope.FromJson("{\"text\":\"loop\"}", cyclicContext) ?? throw new InvalidOperationException("Missing cycle.");
cyclic.Next = cyclic;
using (var document = JsonDocument.Parse(cyclic.ToJson(cyclicContext)))
{
    Check(!document.RootElement.TryGetProperty("next", out var next) || next.ValueKind == JsonValueKind.Null,
        "Reference-handling options were ignored.");
}

var concurrentLookups = 0;
var concurrent = SourceGenerationContext.CreateProbeForTests(new JsonSerializerOptions(),
    _ => Interlocked.Increment(ref concurrentLookups));
await Task.WhenAll(Enumerable.Range(0, 32).Select(_ => Task.Run(() =>
{
    var model = Envelope.FromJson(json, concurrent);
    Check(model?.Next?.Text == "child" && model.ToJson(concurrent).Contains("\"m\"", StringComparison.Ordinal),
        "Concurrent first use corrupted metadata.");
})));
var afterConcurrentFirstUse = Volatile.Read(ref concurrentLookups);
for (var iteration = 0; iteration < 100; iteration++)
    Check(Envelope.FromJson(json, concurrent)?.Text == "first", "Concurrent context warm read failed.");
Check(Volatile.Read(ref concurrentLookups) == afterConcurrentFirstUse, "Concurrent context did not retain its cache.");

using var http = new HttpClient(new EchoHandler());
using var client = new CachingClient(httpClient: http);
client.JsonSerializerContext = context;
var echoed = await client.EchoEnvelopesAsync(new List<Envelope> { first });
Check(echoed.Count == 1 && echoed[0].Text == "first", "HTTP array metadata failed.");
var afterFirstHttp = Volatile.Read(ref lookups);
for (var iteration = 0; iteration < 10; iteration++)
{
    echoed = await client.EchoEnvelopesAsync(new List<Envelope> { first });
    Check(echoed.Count == 1 && echoed[0].Text == "first", "Warm HTTP array failed.");
}
Check(Volatile.Read(ref lookups) == afterFirstHttp, "HTTP array calls rebuilt metadata.");
Console.WriteLine("metadata-cache-contract-passed");

static void Check(bool condition, string message)
{
    if (!condition) throw new InvalidOperationException(message);
}

internal sealed class YesNoBooleanConverter : JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.GetString() == "yes";
    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value ? "yes" : "no");
}

internal sealed class EchoHandler : HttpMessageHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var body = await request.Content!.ReadAsStringAsync(cancellationToken);
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            RequestMessage = request,
            Content = new StringContent(body, Encoding.UTF8, "application/json"),
        };
    }
}
""";
}
