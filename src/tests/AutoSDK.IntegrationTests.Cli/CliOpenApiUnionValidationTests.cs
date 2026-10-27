using System.Runtime.InteropServices;

namespace AutoSDK.IntegrationTests;

public partial class CliTests
{
    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Generate_ValidateOpenApiProviderUnion_OfflineContracts(bool nativeAot)
    {
        const string spec = """
        openapi: 3.0.3
        info: { title: Provider union, version: '1' }
        paths: {}
        components:
          schemas:
            Request:
              type: object
              required: [provider]
              properties:
                provider:
                  anyOf:
                    - type: object
                      required: [type, voice]
                      properties:
                        type: { type: string, enum: [alpha] }
                        voice: { type: string }
                    - type: object
                      required: [type, voice]
                      properties:
                        type: { type: string, enum: [beta] }
                        voice: { type: string }
        """;
        await GenerateFromContentAsync("provider-union.yaml", spec, targetFramework: "net10.0",
            additionalArguments: ["--validate-any-ofs"], assertBuiltOutput: async directory =>
            {
                var sdk = Path.Combine(directory, "Oag.csproj");
                await File.WriteAllTextAsync(sdk, (await File.ReadAllTextAsync(sdk)).Replace("</Project>",
                    "<PropertyGroup><IsTrimmable>true</IsTrimmable></PropertyGroup><ItemGroup><Compile Remove=\"Consumer/**/*.cs\" /></ItemGroup></Project>", StringComparison.Ordinal));
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
                var request = Request.FromJson("""{"provider":{"type":"beta","voice":"fixture"}}""")!;
                if (request.Provider.Object is not RequestProviderVariant2 { Voice: "fixture" }) throw new Exception("Wrong provider selected");
                if (Request.FromJson(request.ToJson())!.Provider.Object is not RequestProviderVariant2) throw new Exception("Roundtrip changed provider");
                var rejected = false;
                try { Request.FromJson("""{"provider":{"type":"unknown","voice":"fixture"}}"""); }
                catch (JsonException) { rejected = true; }
                if (!rejected) throw new Exception("Unknown provider accepted");
                Console.WriteLine("openapi-provider-validation-passed");
                """");
                var publish = Path.Combine(consumer, "publish");
                var built = await RunDotnetAsync(consumer, "publish", "Probe.csproj", "-c", "Release", "-r", RuntimeInformation.RuntimeIdentifier, "-o", publish);
                built.ExitCode.Should().Be(0, built.StandardOutput + built.StandardError);
                var run = await RunProcessAsync(Path.Combine(publish, OperatingSystem.IsWindows() ? "Probe.exe" : "Probe"), publish);
                run.ExitCode.Should().Be(0, run.StandardOutput + run.StandardError);
                run.StandardOutput.Should().Contain("openapi-provider-validation-passed");
            });
    }
}
