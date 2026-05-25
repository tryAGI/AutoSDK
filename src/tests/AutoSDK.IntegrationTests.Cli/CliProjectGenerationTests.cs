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
  /widgets/batch:
    post:
      operationId: createWidgetsBatch
      tags:
        - Widgets
      summary: Create widgets in batch.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: array
              items:
                $ref: '#/components/schemas/CreateWidgetRequest'
      responses:
        '200':
          description: OK
  /widgets/list:
    get:
      operationId: widgetsList
      tags:
        - Widgets
      summary: List widgets.
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: array
                items:
                  $ref: '#/components/schemas/Widget'
  /widgets/{id}/cancel:
    post:
      operationId: widgetsCancel
      tags:
        - Widgets
      summary: Cancel a widget.
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
  /widgets/configure:
    post:
      operationId: configureWidget
      tags:
        - Widgets
      summary: Configure a widget.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              required:
                - label
                - count
              properties:
                label:
                  type: string
                count:
                  type: integer
      responses:
        '200':
          description: OK
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
        tags:
          type: array
          items:
            type: string
        priority:
          type: integer
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

            // #339: an object request body is flattened into per-field flags that bind straight
            // to the SDK's convenience overload, instead of a single opaque --request-json blob.
            var operationCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateWidgetCommand*ApiCommand.g.cs")
                .Single();
            var operationCommand = await File.ReadAllTextAsync(operationCommandPath).ConfigureAwait(false);
            operationCommand.Should().Contain("new Command(@\"create-widget\"");
            operationCommand.Should().NotContain("--request-json");
            operationCommand.Should().NotContain("ReadRequestAsync<");
            // Required scalar -> positional argument; array -> repeatable option; scalar -> option.
            operationCommand.Should().Contain("Argument<string> NameOption");
            operationCommand.Should().Contain("@\"--tags\"");
            operationCommand.Should().Contain("@\"--priority\"");
            operationCommand.Should().Contain("name: name,");
            operationCommand.Should().Contain("tags: tags,");
            operationCommand.Should().Contain("priority: priority,");
            operationCommand.Should().Contain("global::Oag.SourceGenerationContext.Default");

            // #339: a "direct" body (raw array/string/enum/binary) has no fields to flatten, so it
            // keeps the --request-json / --request-file escape hatch.
            var directBodyCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateWidgetsBatch*ApiCommand.g.cs")
                .Single();
            var directBodyCommand = await File.ReadAllTextAsync(directBodyCommandPath).ConfigureAwait(false);
            directBodyCommand.Should().Contain("--request-json");
            directBodyCommand.Should().Contain("--request-file");
            directBodyCommand.Should().Contain("ReadRequestAsync<");
            directBodyCommand.Should().Contain("request: request,");

            // #345: an operation id that repeats its tag (widgetsList under the Widgets tag) has the
            // redundant tag prefix stripped from the nested command name -> "list", not "widgets-list".
            var listCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*WidgetsList*ApiCommand.g.cs")
                .Single();
            var listCommand = await File.ReadAllTextAsync(listCommandPath).ConfigureAwait(false);
            listCommand.Should().Contain("new Command(@\"list\"");
            listCommand.Should().NotContain("new Command(@\"widgets-list\"");

            // #340: a path-template parameter is hoisted to a positional Argument, not a --flag.
            var pathCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*WidgetsCancel*ApiCommand.g.cs")
                .Single();
            var pathCommand = await File.ReadAllTextAsync(pathCommandPath).ConfigureAwait(false);
            pathCommand.Should().Contain("new Command(@\"cancel\"");
            pathCommand.Should().Contain("Argument<string> Id");
            pathCommand.Should().Contain("command.Arguments.Add(Id);");
            pathCommand.Should().NotContain("Option<string> Id");

            // #340: with no path template and no resource-identifier string property, nothing is
            // hoisted — required body fields stay as required flags rather than opaque positionals.
            var configureCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*ConfigureWidget*ApiCommand.g.cs")
                .Single();
            var configureCommand = await File.ReadAllTextAsync(configureCommandPath).ConfigureAwait(false);
            configureCommand.Should().Contain("Option<string> Label");
            configureCommand.Should().Contain("Option<int> Count");
            configureCommand.Should().Contain("Required = true");
            configureCommand.Should().NotContain("Argument<");

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
