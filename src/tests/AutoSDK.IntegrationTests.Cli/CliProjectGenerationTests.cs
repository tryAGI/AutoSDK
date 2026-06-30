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
  /tasks:
    post:
      operationId: createTask
      x-cli-wait: always
      tags:
        - Tasks
      summary: Create a task.
      responses:
        '202':
          description: Accepted
          headers:
            Location:
              schema:
                type: string
  /tasks/{id}:
    get:
      operationId: getTask
      tags:
        - Tasks
      summary: Get task status.
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                oneOf:
                  - type: object
                    required:
                      - status
                    properties:
                      status:
                        type: string
                        enum:
                          - pending
                  - type: object
                    required:
                      - status
                    properties:
                      status:
                        type: string
                        enum:
                          - completed
                      result:
                        type: string
                discriminator:
                  propertyName: status
  /scrape:
    post:
      operationId: scrape
      tags:
        - Scraping
      summary: Scrape a page.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/ScrapeOptions'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Widget'
  /crawl:
    post:
      operationId: crawl
      tags:
        - Crawling
      summary: Crawl a page.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CrawlRequest'
      responses:
        '200':
          description: OK
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
  /search:
    get:
      operationId: searchAndScrape
      tags:
        - Search
      summary: Search and scrape.
      responses:
        '200':
          description: OK
  /widgets/configure:
    post:
      operationId: configureWidget
      x-cli-command-name: configure
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
  /widgets/advanced:
    post:
      operationId: configureAdvancedWidget
      tags:
        - Widgets
      summary: Configure advanced.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              allOf:
                - $ref: '#/components/schemas/CreateWidgetRequest'
                - type: object
                  properties:
                    advanced:
                      type: boolean
      responses:
        '200':
          description: OK
  /uploads:
    post:
      operationId: createUpload
      tags:
        - Uploads
      summary: Create an upload.
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreateUploadRequest'
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
        input:
          type: string
        mode:
          type: string
          enum:
            - standard
            - advanced
        tags:
          type: array
          items:
            type: string
        enabled:
          type: boolean
        priority:
          type: integer
        params:
          type: string
    CreateUploadRequest:
      type: object
      required:
        - filename
        - type
      properties:
        filename:
          type: string
        type:
          type: string
          enum:
            - ephemeral
    ScrapeOptions:
      type: object
      properties:
        formats:
          type: array
          items:
            type: string
        onlyMainContent:
          type: boolean
        limit:
          type: integer
    CrawlRequest:
      type: object
      required:
        - url
        - webhook
      properties:
        url:
          type: string
        scrapeOptions:
          $ref: '#/components/schemas/ScrapeOptions'
        webhook:
          $ref: '#/components/schemas/WebhookConfig'
    WebhookConfig:
      type: object
      required:
        - url
      properties:
        url:
          type: string
          format: uri
        headers:
          type: object
          additionalProperties:
            type: string
        metadata:
          type: object
        events:
          type: array
          items:
            type: string
            enum:
              - completed
              - errored
    Widget:
      type: object
      properties:
        status:
          type: string
          x-cli-format: key
        id:
          type: string
        name:
          type: string
        markdown:
          type: string
          x-cli-format: code
        internalNote:
          type: string
          x-cli-format: hidden
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
                    "--auto-detect-status-polling",
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
                    "--api-key-env-var", "OAG_API_KEY",
                    "--cli-credential-file")
                .ConfigureAwait(false);

            Console.WriteLine(cliProjectResult.StandardOutput);
            Console.WriteLine(cliProjectResult.StandardError);
            cliProjectResult.ExitCode.Should().Be(0);

            var cliProject = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Oag.CLI.csproj")).ConfigureAwait(false);
            cliProject.Should().Contain("<PackAsTool>true</PackAsTool>");
            cliProject.Should().Contain("<GeneratePackageOnBuild Condition=\" '$(Configuration)' == 'Release' \">true</GeneratePackageOnBuild>");
            cliProject.Should().Contain("<PackageReadmeFile>README.md</PackageReadmeFile>");
            cliProject.Should().Contain("<None Include=\"README.md\" Pack=\"true\" PackagePath=\"\\\" />");
            cliProject.Should().Contain("<ToolCommandName>tryagi-oag</ToolCommandName>");
            cliProject.Should().Contain("<MinVerTagPrefix>v</MinVerTagPrefix>");
            cliProject.Should().Contain("<PackageReference Include=\"MinVer\" Version=\"7.0.0\">");
            var readme = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "README.md")).ConfigureAwait(false);
            readme.Should().Contain("dotnet tool install --global Oag.CLI --prerelease");
            readme.Should().Contain("tryagi-oag api --help");

            // The ApiCommand aggregate is still generated (api-only consumers wire it), but ...
            var apiCommand = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Commands", "ApiCommand.g.cs")).ConfigureAwait(false);
            apiCommand.Should().Contain("new Command(\"api\"");

            // #345: ... by default the full-project Program.cs adds tag groups to the root directly,
            // dropping the redundant top-level "api" wrapper (restorable via --cli-keep-api-group).
            var program = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Program.cs")).ConfigureAwait(false);
            program.Should().Contain("rootCommand.Subcommands.Add(WidgetsApiGroupCommand.Create());");
            program.Should().NotContain("rootCommand.Subcommands.Add(ApiCommand.Create());");

            // #339: an object request body is flattened into per-field flags that bind straight
            // to the SDK's convenience overload, instead of a single opaque --request-json blob.
            var operationCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateWidgetCommand*ApiCommand.g.cs")
                .Single();
            var operationCommand = await File.ReadAllTextAsync(operationCommandPath).ConfigureAwait(false);
            operationCommand.Should().Contain("new Command(@\"create-widget\"");
            // Object body is flattened into per-field flags that bind straight to the convenience
            // overload — no opaque non-nullable ReadRequestAsync<T> deserialization of the whole body.
            operationCommand.Should().NotContain("ReadRequestAsync<");
            // Required scalar -> positional argument; array -> repeatable option; scalar -> option.
            operationCommand.Should().Contain("Argument<string> NameOption");
            operationCommand.Should().Contain("@\"--tags\"");
            operationCommand.Should().Contain("CliRuntime.CreateNullableBoolOption");
            operationCommand.Should().Contain("@\"--enabled\"");
            operationCommand.Should().Contain("@\"--priority\"");
            operationCommand.Should().Contain("Option<global::Oag.CreateWidgetRequestMode?> Mode");
            operationCommand.Should().Contain("name: name,");
            operationCommand.Should().Contain("tags: tags,");
            operationCommand.Should().Contain("enabled: enabled,");
            operationCommand.Should().Contain("priority: priority,");
            operationCommand.Should().Contain("@params: @params,");
            operationCommand.Should().Contain("mode: mode,");
            operationCommand.Should().Contain("global::Oag.SourceGenerationContext.Default");
            operationCommand.Should().Contain("private static string FormatResponse(");
            operationCommand.Should().Contain("CustomizeResponseText");
            operationCommand.Should().Contain("[\"status\"] = CliFormatHint.Key");
            operationCommand.Should().Contain("[\"markdown\"] = CliFormatHint.Code");
            operationCommand.Should().Contain("[\"internalNote\"] = CliFormatHint.Hidden");

            // #343: an object body with optional fields also accepts --request-json/--request-file as
            // an optional base body. Per-field flags override it; the positional/required fields still
            // come from CLI args. Optional fields merge as `flag ?? base?.Prop`.
            operationCommand.Should().Contain("Option<string?> InputOption");
            operationCommand.Should().Contain("name: @\"--input\"");
            operationCommand.Should().Contain("Option<string?> RequestInput");
            operationCommand.Should().Contain("new(@\"--request-input\")");
            operationCommand.Should().Contain("--request-json");
            operationCommand.Should().Contain("ReadRequestOrDefaultAsync<global::Oag.CreateWidgetRequest>");
            operationCommand.Should().Contain("RequestInput,");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default)");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default)");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default)");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, Enabled) ? parseResult.GetValue(Enabled) : (__requestBase is { } __EnabledBaseValue ? __EnabledBaseValue.Enabled : default)");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, Priority) ? parseResult.GetValue(Priority) : (__requestBase is { } __PriorityBaseValue ? __PriorityBaseValue.Priority : default)");
            operationCommand.Should().Contain("CliRuntime.WasSpecified(parseResult, Params) ? parseResult.GetValue(Params) : (__requestBase is { } __ParamsBaseValue ? __ParamsBaseValue.Params : default)");
            operationCommand.Should().NotContain("__@paramsBaseValue");
            // The positional/required name is taken from the argument, never the base body.
            operationCommand.Should().Contain("var name = parseResult.GetRequiredValue(NameOption);");

            // AutoSDK #354: required enum request properties can still surface as optional SDK
            // convenience parameters when they have a CLR default. Base-body fallback must gate on
            // WasSpecified rather than coalescing a non-nullable enum with a nullable base value.
            var uploadCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateUpload*ApiCommand.g.cs")
                .Single();
            var uploadCommand = await File.ReadAllTextAsync(uploadCommandPath).ConfigureAwait(false);
            uploadCommand.Should().Contain("Option<global::Oag.CreateUploadRequestType> Type");
            uploadCommand.Should().Contain("var type = CliRuntime.WasSpecified(parseResult, Type) ? parseResult.GetValue(Type) : (__requestBase is { } __TypeBaseValue ? __TypeBaseValue.Type : default)");
            uploadCommand.Should().NotContain("parseResult.GetValue(Type) ??");
            uploadCommand.Should().NotContain("?? __requestBase?.Type");

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
            listCommand.Should().Contain("TryWriteOutputDirectoryAsync");
            listCommand.Should().Contain("@\"$self\"");

            // Firecrawl regression: do not strip the tag token when it is part of the natural verb
            // phrase ("search-and-scrape"), otherwise the generated command becomes "and-scrape".
            var searchCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*SearchAndScrape*ApiCommand.g.cs")
                .Single(path => string.Equals(Path.GetFileName(path), "SearchSearchAndScrapeCommandApiCommand.g.cs", StringComparison.Ordinal));
            var searchCommand = await File.ReadAllTextAsync(searchCommandPath).ConfigureAwait(false);
            searchCommand.Should().Contain("new Command(@\"search-and-scrape\"");
            searchCommand.Should().NotContain("new Command(@\"and-scrape\"");

            // #341: a create operation with a generated SDK wait companion emits --wait,
            // --poll-interval, and --wait-timeout and dispatches to <Method>WaitAsync.
            var createTaskCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*CreateTask*ApiCommand.g.cs")
                .Single();
            var createTaskCommand = await File.ReadAllTextAsync(createTaskCommandPath).ConfigureAwait(false);
            createTaskCommand.Should().Contain("new(\"--wait\")");
            createTaskCommand.Should().Contain("new(\"--poll-interval\")");
            createTaskCommand.Should().Contain("new(\"--wait-timeout\")");
            createTaskCommand.Should().Contain("CliRuntime.CreatePollingOptions");
            createTaskCommand.Should().Contain("client.Tasks.CreateTaskWaitAsync(");

            // #346: a reused request schema emits a shared option-set that can be used bare or
            // with a prefix in nested request objects.
            var scrapeOptionSet = await File.ReadAllTextAsync(
                    Path.Combine(cliDirectory, "Commands", "ScrapeOptionsOptionSet.g.cs"))
                .ConfigureAwait(false);
            scrapeOptionSet.Should().Contain("Create(string? prefix = null)");
            scrapeOptionSet.Should().Contain("$\"--{normalizedPrefix}only-main-content\"");
            scrapeOptionSet.Should().Contain("$\"--{normalizedPrefix}formats\"");

            var scrapeCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*Scrape*ApiCommand.g.cs")
                .Single(path => string.Equals(Path.GetFileName(path), "ScrapingScrapeCommandApiCommand.g.cs", StringComparison.Ordinal));
            var scrapeCommand = await File.ReadAllTextAsync(scrapeCommandPath).ConfigureAwait(false);
            scrapeCommand.Should().Contain("ScrapeOptionsOptionSet.Create();");
            scrapeCommand.Should().Contain("command.Options.Add(ScrapeOptionsOptionSetOptions.OnlyMainContent);");

            // #348: webhook-shaped nested request objects emit a composite --webhook-* builder.
            var crawlCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*Crawl*ApiCommand.g.cs")
                .Single(path => Path.GetFileName(path).Contains("CrawlCommandApiCommand", StringComparison.Ordinal));
            var crawlCommand = await File.ReadAllTextAsync(crawlCommandPath).ConfigureAwait(false);
            crawlCommand.Should().Contain("ScrapeOptionsOptionSet.Create(@\"scrape\")");
            crawlCommand.Should().Contain("--webhook-url");
            crawlCommand.Should().Contain("--webhook-header");
            crawlCommand.Should().Contain("--webhook-metadata");
            crawlCommand.Should().Contain("--webhook-event");
            crawlCommand.Should().NotContain("--scrape-options-url");
            crawlCommand.Should().Contain("new global::Oag.WebhookConfig");
            crawlCommand.Should().Contain("CliRuntime.SerializeKeyValuePairs");
            crawlCommand.Should().Contain("CliRuntime.SerializeStringArray");
            crawlCommand.Should().Contain("var __webhookWebhookUrlRequired =");
            crawlCommand.Should().Contain("Url = __webhookWebhookUrlRequired,");
            crawlCommand.Should().Contain("throw new CliException(@\"Specify --webhook-url or include webhook in the base request body.\")");
            crawlCommand.Should().Contain("webhook: webhook!,");

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
            // #345: x-cli-command-name overrides the derived command name verbatim.
            configureCommand.Should().Contain("new Command(@\"configure\"");
            configureCommand.Should().NotContain("new Command(@\"configure-widget\"");
            configureCommand.Should().Contain("Option<string> Label");
            configureCommand.Should().Contain("Option<int> Count");
            configureCommand.Should().Contain("Required = true");
            configureCommand.Should().NotContain("Argument<");
            // Required flags must be read with GetRequiredValue (non-null), not GetValue — passing a
            // nullable to a non-nullable SDK parameter trips CS8604 in strict consumers (Firecrawl).
            configureCommand.Should().Contain("var label = parseResult.GetRequiredValue(Label);");
            configureCommand.Should().NotContain("parseResult.GetValue(Label)");

            // #339 regression: a composite (allOf/oneOf) request body does NOT flatten into per-field
            // parameters, so it must keep the --request-json/--request-file blob and bind via request:
            // rather than silently sending an empty body (the Firecrawl scrape AllOf<...> case).
            var compositeBodyCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*ConfigureAdvancedWidget*ApiCommand.g.cs")
                .Single();
            var compositeBodyCommand = await File.ReadAllTextAsync(compositeBodyCommandPath).ConfigureAwait(false);
            compositeBodyCommand.Should().Contain("--request-json");
            compositeBodyCommand.Should().Contain("ReadRequestAsync<global::Oag.AllOf<");
            compositeBodyCommand.Should().Contain("request: request,");

            var runtime = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "CliRuntime.cs")).ConfigureAwait(false);
            runtime.Should().Contain("\"OAG_API_KEY\"");
            runtime.Should().Contain("CredentialFileDirectoryName = \".oag\"");
            runtime.Should().Contain("CreateNullableBoolOption");
            runtime.Should().Contain("ParseDuration");
            runtime.Should().Contain("ReadInputAsync");
            runtime.Should().Contain("DeserializeJsonValue");
            runtime.Should().Contain("FormatHumanReadable");
            runtime.Should().Contain("CliFormatHint");
            runtime.Should().Contain("SerializeKeyValuePairs");
            runtime.Should().Contain("switch (raw.ToUpperInvariant())");
            runtime.Should().Contain("requestJson ?? throw new CliException(\"Request input is required.\")");
            runtime.Should().Contain("requestJson!");
            runtime.Should().Contain("pair.IndexOf('=', StringComparison.Ordinal)");
            runtime.Should().Contain("SerializeStringArray");
            runtime.Should().Contain("TryWriteOutputDirectoryAsync");
            runtime.Should().Contain("GetCredentialFilePath()");
            runtime.Should().Contain("ReadCredentialFileAsync");
            runtime.Should().Contain("flag (--api-key)");
            runtime.Should().Contain("DisplayName: $\"env var {environmentVariable}\"");
            runtime.Should().Contain("credential file");
            runtime.Should().Contain("secret.Length < 12 ? \"***\"");
            runtime.Should().Contain("EndPointAuthorization");

            var authCommand = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "Commands", "AuthCommand.cs")).ConfigureAwait(false);
            authCommand.Should().Contain("sources:");
            authCommand.Should().Contain("source.DisplayName");
            authCommand.Should().Contain("not present");
            authCommand.Should().Contain("CliOptions.Json");
            authCommand.Should().Contain("status.Authenticated ? \"true\" : \"false\"");

            var cliOptions = await File.ReadAllTextAsync(Path.Combine(cliDirectory, "CliOptions.cs")).ConfigureAwait(false);
            cliOptions.Should().Contain("new(\"--json\")");
            cliOptions.Should().Contain("new(\"--output-dir\")");

            var buildResult = await RunDotnetAsync(
                    cliDirectory,
                    "build",
                    "--disable-build-servers",
                    Path.Combine(cliDirectory, "Oag.CLI.csproj"))
                .ConfigureAwait(false);

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
            buildResult.StandardOutput.Should().NotContain("CS8604");
            buildResult.StandardError.Should().NotContain("CS8604");

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

    [TestMethod]
    public async Task CliProject_RespectsMethodNamingConvention()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: Summary API
  version: 1.0.0
servers:
  - url: https://api.example.test
paths:
  /widgets:
    post:
      operationId: widgetsCreateByOperationId
      tags:
        - Widgets
      summary: Make a widget.
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Widget'
components:
  schemas:
    Widget:
      type: object
      properties:
        id:
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
                    "--namespace", "SummarySdk",
                    "--clientClassName", "SummaryClient",
                    "--methodNamingConvention", "Summary",
                    "--targetFramework", "net10.0",
                    "--output", sdkDirectory)
                .ConfigureAwait(false);

            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var sdkProjectPath = Path.Combine(sdkDirectory, "SummarySdk.csproj");
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
                    "--namespace", "SummarySdk",
                    "--clientClassName", "SummaryClient",
                    "--methodNamingConvention", "Summary",
                    "--targetFramework", "net10.0",
                    "--output", cliDirectory,
                    "--package-id", "SummarySdk.CLI",
                    "--tool-command-name", "summary-sdk")
                .ConfigureAwait(false);

            Console.WriteLine(cliProjectResult.StandardOutput);
            Console.WriteLine(cliProjectResult.StandardError);
            cliProjectResult.ExitCode.Should().Be(0);

            var operationCommandPath = Directory
                .EnumerateFiles(Path.Combine(cliDirectory, "Commands"), "*MakeAWidget*ApiCommand.g.cs")
                .Single();
            var operationCommand = await File.ReadAllTextAsync(operationCommandPath).ConfigureAwait(false);
            operationCommand.Should().Contain("client.MakeAWidgetAsync(");
            operationCommand.Should().NotContain("client.WidgetsCreateByOperationIdAsync(");

            var buildResult = await RunDotnetAsync(
                    cliDirectory,
                    "build",
                    "--disable-build-servers",
                    Path.Combine(cliDirectory, "SummarySdk.CLI.csproj"))
                .ConfigureAwait(false);

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
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
