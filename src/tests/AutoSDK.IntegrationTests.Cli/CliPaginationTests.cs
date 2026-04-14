using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliPaginationTests
{
    [TestMethod]
    public async Task Generate_WithSpeakeasyCursorPagination_EmitsPaginationHelpers_AndBuilds()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: SpeakeasyPagination
  version: 1.0.0
paths:
  /widgets:
    get:
      operationId: listWidgets
      parameters:
        - in: query
          name: cursor
          schema:
            type: string
        - in: query
          name: limit
          schema:
            type: integer
      x-speakeasy-pagination:
        type: cursor
        inputs:
          - name: cursor
            in: query
            type: cursor
          - name: limit
            in: query
            type: limit
        outputs:
          results: $.data
          nextCursor: $.next_cursor
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_cursor:
                    type: string
""";

        await GenerateFromContentAsync(
            fileName: "pagination-speakeasy.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public sealed class AutoSDKPage<TItem, TResponse>");
                content.Should().Contain("ListWidgetsAsPageAsync");
                content.Should().Contain("ListWidgetsAsItemsAsync");
                content.Should().Contain("AutoSDKPaginationSupport.ExtractItems<");
            });
    }

    [TestMethod]
    public async Task Generate_WithStainlessHeaderAndUrlPagination_EmitsTraversalSupport_AndBuilds()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: StainlessPagination
  version: 1.0.0
paths:
  /events:
    get:
      operationId: listEvents
      parameters:
        - in: query
          name: after
          schema:
            type: string
            x-stainless-pagination-property:
              purpose: next_cursor_param
      responses:
        '200':
          description: OK
          headers:
            X-Next-Cursor:
              schema:
                type: string
          content:
            application/json:
              schema:
                type: array
                x-stainless-pagination-property:
                  is_top_level_array: true
                items:
                  type: object
                  x-stainless-pagination-property:
                    purpose: next_cursor_field
                    from_header: X-Next-Cursor
                  properties:
                    id:
                      type: string
  /records:
    get:
      operationId: listRecords
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  data:
                    type: array
                    x-stainless-pagination-property:
                      purpose: items
                    items:
                      type: object
                      properties:
                        id:
                          type: string
                  next_url:
                    type: string
                    format: uri
                    x-stainless-pagination-property:
                      purpose: cursor_url_field
""";

        await GenerateFromContentAsync(
            fileName: "pagination-stainless.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("GetHeaderString(__response, \"X-Next-Cursor\")");
                content.Should().Contain("AbsoluteRequestUriOverride = __nextPageUri");
                content.Should().Contain("requestOptions?.AbsoluteRequestUriOverride");
                content.Should().Contain("public sealed class AutoSDKPage<TItem, TResponse>");
            });
    }

    private static async Task GenerateFromContentAsync(
        string fileName,
        string specContent,
        string targetFramework = "net8.0",
        Func<string, Task>? assertGeneratedOutput = null)
    {
        var tempSpecDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempSpecDirectory);

        var specPath = Path.Combine(tempSpecDirectory, fileName);

        try
        {
            await File.WriteAllTextAsync(specPath, specContent);
            await GenerateAsync(specPath, targetFramework, assertGeneratedOutput);
        }
        finally
        {
            TryDeleteDirectory(tempSpecDirectory);
        }
    }

    private static async Task GenerateAsync(
        string specPath,
        string targetFramework,
        Func<string, Task>? assertGeneratedOutput)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempDirectory);

        try
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Oag",
                "--targetFramework", targetFramework,
                "--output", tempDirectory);

            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            if (assertGeneratedOutput != null)
            {
                await assertGeneratedOutput(tempDirectory);
            }

            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Oag.csproj"), $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{targetFramework}</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>

  <PropertyGroup Label=""Analyzers"">
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisLevel>latest</AnalysisLevel>
    <AnalysisMode>All</AnalysisMode>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>");

            var buildResult = await RunDotnetAsync(
                tempDirectory,
                "build",
                "--disable-build-servers",
                Path.Combine(tempDirectory, "Oag.csproj"));

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
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

        await process.WaitForExitAsync();

        return
        (
            process.ExitCode,
            await standardOutputTask,
            await standardErrorTask
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
