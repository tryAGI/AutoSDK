using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoSDK.IntegrationTests;

[TestClass]
public sealed class CliProjectGenerationTests
{
    [TestMethod]
    public async Task CliProject_GeneratesPackAsToolApiCommands_AndBuilds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: Widget API
  version: 1.0.0
servers:
  - url: https://api.example.test
security:
  - BearerAuth: []
paths:
  /widgets:
    post:
      operationId: createWidget
      tags:
        - Widgets
      summary: Create a widget.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreateWidgetRequest'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Widget'
components:
  securitySchemes:
    BearerAuth:
      type: http
      scheme: bearer
  schemas:
    CreateWidgetRequest:
      type: object
      required:
        - name
      properties:
        name:
          type: string
    Widget:
      type: object
      properties:
        id:
          type: string
        name:
          type: string
""";

        var rootDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var sdkDirectory = Path.Combine(rootDirectory, "sdk");
        var cliDirectory = Path.Combine(rootDirectory, "cli");
        Directory.CreateDirectory(rootDirectory);

        try
        {
            var specPath = Path.Combine(rootDirectory, "openapi.yaml");
            await File.WriteAllTextAsync(specPath, spec).ConfigureAwait(false);

            var repositoryDirectory = GetRepositoryDirectory();

            var generateResult = await RunDotnetAsync(
                    repositoryDirectory,
                    "run",
                    "--disable-build-servers",
                    "--no-launch-profile",
                    "--project", "src/libs/AutoSDK.CLI",
                    "generate", specPath,
                    "--namespace", "Oag",
                    "--clientClassName", "OagClient",
                    "--targetFramework", "net10.0",
                    "--output", sdkDirectory)
                .ConfigureAwait(false);

            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var sdkProjectPath = Path.Combine(sdkDirectory, "Oag.csproj");
            await File.WriteAllTextAsync(
                    sdkProjectPath,
                    """
                    <Project Sdk="Microsoft.NET.Sdk">
                      <PropertyGroup>
                        <TargetFramework>net10.0</TargetFramework>
                        <LangVersion>preview</LangVersion>
                        <Nullable>enable</Nullable>
                        <ImplicitUsings>enable</ImplicitUsings>
                      </PropertyGroup>
                    </Project>
                    """)
                .ConfigureAwait(false);

            var cliProjectResult = await RunDotnetAsync(
                    repositoryDirectory,
                    "run",
                    "--disable-build-servers",
                    "--no-launch-profile",
                    "--project", "src/libs/AutoSDK.CLI",
                    "cli-project", specPath,
                    "--sdk-project", sdkProjectPath,
                    "--namespace", "Oag",
                    "--clientClassName", "OagClient",
                    "--targetFramework", "net10.0",
                    "--output", cliDirectory,
                    "--package-id", "Oag.CLI",
                    "--tool-command-name", "tryagi-oag",
                    "--api-key-env-var", "OAG_API_KEY")
                .ConfigureAwait(false);

            Console.WriteLine(cliProjectResult.StandardOutput);
            Console.WriteLine(cliProjectResult.StandardError);
            cliProjectResult.ExitCode.Should().Be(0);

            var cliProject = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Oag.CLI.csproj")).ConfigureAwait(false);
            cliProject.Should().Contain("<PackAsTool>true</PackAsTool>");
            cliProject.Should().Contain("<ToolCommandName>tryagi-oag</ToolCommandName>");

            var apiCommand = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Commands", "ApiCommand.g.cs")).ConfigureAwait(false);
            apiCommand.Should().Contain("new Command(\"api\"");

            var operationCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateWidget*ApiCommand.g.cs")
                .Single();
            var operationCommand = await File.ReadAllTextAsync(operationCommandPath).ConfigureAwait(false);
            operationCommand.Should().Contain("new Command(@\"create-widget\"");
            operationCommand.Should().Contain("--request-json");
            operationCommand.Should().Contain("--request-file");
            operationCommand.Should().Contain("ReadRequestAsync<global::Oag.CreateWidgetRequest>");
            operationCommand.Should().Contain("global::Oag.SourceGenerationContext.Default");

            var runtime = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "CliRuntime.cs")).ConfigureAwait(false);
            runtime.Should().Contain("\"OAG_API_KEY\"");
            runtime.Should().Contain("EndPointAuthorization");

            var buildResult = await RunDotnetAsync(
                    cliDirectory,
                    "build",
                    "--disable-build-servers",
                    Path.Combine(cliDirectory, "Oag.CLI.csproj"))
                .ConfigureAwait(false);

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);

            var publishResult = await RunDotnetAsync(
                    cliDirectory,
                    "publish",
                    "--disable-build-servers",
                    Path.Combine(cliDirectory, "Oag.CLI.csproj"),
                    "-c", "Release",
                    "-r", RuntimeInformation.RuntimeIdentifier,
                    "--self-contained", "true",
                    "-p:PublishTrimmed=true",
                    "-p:TrimMode=full",
                    "-p:SuppressTrimAnalysisWarnings=false")
                .ConfigureAwait(false);

            Console.WriteLine(publishResult.StandardOutput);
            Console.WriteLine(publishResult.StandardError);
            publishResult.ExitCode.Should().Be(0);

            var manualDirectory = Path.Combine(rootDirectory, "manual");
            var generatedApiDirectory = Path.Combine(manualDirectory, "GeneratedApi");
            Directory.CreateDirectory(manualDirectory);

            var apiOnlyResult = await RunDotnetAsync(
                    repositoryDirectory,
                    "run",
                    "--disable-build-servers",
                    "--no-launch-profile",
                    "--project", "src/libs/AutoSDK.CLI",
                    "cli-project", specPath,
                    "--sdk-project", sdkProjectPath,
                    "--namespace", "Oag",
                    "--clientClassName", "OagClient",
                    "--targetFramework", "net10.0",
                    "--output", generatedApiDirectory,
                    "--package-id", "Manual.Cli.GeneratedApi",
                    "--root-namespace", "Manual.Cli.GeneratedApi",
                    "--user-secrets-id", "Manual.Cli",
                    "--tool-command-name", "tryagi-manual",
                    "--api-key-env-var", "OAG_API_KEY",
                    "--api-only")
                .ConfigureAwait(false);

            Console.WriteLine(apiOnlyResult.StandardOutput);
            Console.WriteLine(apiOnlyResult.StandardError);
            apiOnlyResult.ExitCode.Should().Be(0);

            File.Exists(Path.Combine(generatedApiDirectory, "Manual.Cli.GeneratedApi.csproj")).Should().BeFalse();
            File.Exists(Path.Combine(generatedApiDirectory, "Program.cs")).Should().BeFalse();
            File.Exists(Path.Combine(generatedApiDirectory, "Commands", "AuthCommand.cs")).Should().BeFalse();

            var apiOnlyApiCommand = await File.ReadAllTextAsync(Path.Combine(generatedApiDirectory, "Commands", "ApiCommand.g.cs")).ConfigureAwait(false);
            apiOnlyApiCommand.Should().Contain("command.Options.Add(CliOptions.ApiKey);");

            await File.WriteAllTextAsync(
                    Path.Combine(manualDirectory, "Manual.Cli.csproj"),
                    $$"""
                      <Project Sdk="Microsoft.NET.Sdk">
                        <PropertyGroup>
                          <OutputType>Exe</OutputType>
                          <TargetFramework>net10.0</TargetFramework>
                          <LangVersion>preview</LangVersion>
                          <Nullable>enable</Nullable>
                          <ImplicitUsings>enable</ImplicitUsings>
                        </PropertyGroup>
                        <ItemGroup>
                          <PackageReference Include="System.CommandLine" Version="2.0.7" />
                          <ProjectReference Include="{{Path.GetRelativePath(manualDirectory, sdkProjectPath)}}" />
                        </ItemGroup>
                      </Project>
                      """)
                .ConfigureAwait(false);

            await File.WriteAllTextAsync(
                    Path.Combine(manualDirectory, "Program.cs"),
                    """
                    using System.CommandLine;

                    var root = new RootCommand("Manual CLI");
                    root.Subcommands.Add(Manual.Cli.GeneratedApi.Commands.ApiCommand.Create());
                    return await root.Parse(args).InvokeAsync().ConfigureAwait(false);
                    """)
                .ConfigureAwait(false);

            var manualBuildResult = await RunDotnetAsync(
                    manualDirectory,
                    "build",
                    "--disable-build-servers",
                    Path.Combine(manualDirectory, "Manual.Cli.csproj"))
                .ConfigureAwait(false);

            Console.WriteLine(manualBuildResult.StandardOutput);
            Console.WriteLine(manualBuildResult.StandardError);
            manualBuildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(rootDirectory);
        }
    }

    private static string GetRepositoryDirectory()
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        return Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory,
        params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = workingDirectory,
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

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync().ConfigureAwait(false);

        return
        (
            process.ExitCode,
            await standardOutputTask.ConfigureAwait(false),
            await standardErrorTask.ConfigureAwait(false)
        );
    }

    private static void TryDeleteDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            return;
        }

        try
        {
            Directory.Delete(path, recursive: true);
        }
        catch (IOException)
        {
        }
        catch (UnauthorizedAccessException)
        {
        }
    }
}
