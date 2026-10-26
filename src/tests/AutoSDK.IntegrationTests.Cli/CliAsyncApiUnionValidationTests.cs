using System.Runtime.InteropServices;

namespace AutoSDK.IntegrationTests;

public partial class CliTests
{
    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Generate_ValidateMixedAsyncApiUnions_OfflineContracts(bool nativeAot)
    {
        const string spec = """
        {
          "asyncapi":"3.0.0", "info":{"title":"Mixed events","version":"1"},
          "channels":{"events":{"address":"/events","messages":{
            "Alpha":{"payload":{"$ref":"#/components/schemas/Alpha"}},
            "Beta":{"payload":{"$ref":"#/components/schemas/Beta"}},
            "History":{"payload":{"$ref":"#/components/schemas/History"}},
            "Audio":{"payload":{"$ref":"#/components/schemas/Audio"}}}}},
          "operations":{"receive":{"action":"receive","channel":{"$ref":"#/channels/events"},
            "messages":[{"$ref":"#/channels/events/messages/Alpha"},
              {"$ref":"#/channels/events/messages/Beta"},{"$ref":"#/channels/events/messages/History"},
              {"$ref":"#/channels/events/messages/Audio"}]}},
          "components":{"schemas":{
              "Alpha":{"type":"object","required":["type"],"properties":{
                "type":{"type":"string","enum":["alpha"]}}},
              "Beta":{"type":"object","required":["type"],"properties":{
                "type":{"type":"string","enum":["beta"]}}},
              "History":{"oneOf":[{"$ref":"#/components/schemas/Alpha"},{"$ref":"#/components/schemas/Beta"}]},
              "Audio":{"type":"string","format":"binary"}
          }}
        }
        """;
        await GenerateFromContentAsync("mixed-asyncapi.json", spec,
            targetFramework: "net10.0", additionalArguments: ["--validate-any-ofs"],
            assertBuiltOutput: async directory =>
            {
                var sdkProject = Path.Combine(directory, "Oag.csproj");
                await File.WriteAllTextAsync(sdkProject, (await File.ReadAllTextAsync(sdkProject)).Replace(
                    "</Project>", "<PropertyGroup><IsTrimmable>true</IsTrimmable></PropertyGroup><ItemGroup><Compile Remove=\"Consumer/**/*.cs\" /></ItemGroup></Project>",
                    StringComparison.Ordinal));
                var consumer = Path.Combine(directory, "Consumer");
                Directory.CreateDirectory(consumer);
                await File.WriteAllTextAsync(Path.Combine(consumer, "Probe.csproj"), $$"""
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework>
                    <ImplicitUsings>enable</ImplicitUsings><Nullable>enable</Nullable>
                    <PublishTrimmed>true</PublishTrimmed><PublishAot>{{nativeAot.ToString().ToLowerInvariant()}}</PublishAot>
                    <JsonSerializerIsReflectionEnabledByDefault>false</JsonSerializerIsReflectionEnabledByDefault>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors><ILLinkTreatWarningsAsErrors>true</ILLinkTreatWarningsAsErrors>
                  </PropertyGroup>
                  <ItemGroup><ProjectReference Include="../Oag.csproj" /></ItemGroup>
                </Project>
                """);
                await File.WriteAllTextAsync(Path.Combine(consumer, "Program.cs"), """"
                using Oag;
                using System.Text.Json;
                if (JsonSerializer.IsReflectionEnabledByDefault) throw new Exception("Reflection enabled");
                var beta = ServerEvent.FromJson("""{"type":"beta"}""")!.Value;
                if (beta.Object is not Beta) throw new Exception("Wrong event selected");
                var rejected = false;
                try { ServerEvent.FromJson("""{"type":"unknown"}"""); }
                catch (JsonException) { rejected = true; }
                if (!rejected) throw new Exception("An empty nested union became a valid event");
                var audio = ServerEvent.FromJson("\"AQID\"")!.Value;
                if (audio.Object is not byte[] { Length: 3 }) throw new Exception("Binary branch lost");
                Console.WriteLine("mixed-asyncapi-validation-passed");
                """");
                var publish = Path.Combine(consumer, "publish");
                var built = await RunDotnetAsync(consumer, "publish", "Probe.csproj", "-c", "Release",
                    "-r", RuntimeInformation.RuntimeIdentifier, "-o", publish);
                built.ExitCode.Should().Be(0, built.StandardOutput + built.StandardError);
                var run = await RunProcessAsync(Path.Combine(publish, OperatingSystem.IsWindows() ? "Probe.exe" : "Probe"), publish);
                run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
                run.StandardOutput.Should().Contain("mixed-asyncapi-validation-passed");
            });
    }
}
