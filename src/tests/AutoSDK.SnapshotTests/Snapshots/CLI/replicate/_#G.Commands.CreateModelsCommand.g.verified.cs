//HintName: G.Commands.CreateModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? coverImageUrl,
            string? description,
            string? githubUrl,
            string hardware,
            string? licenseUrl,
            string name,
            string owner,
            string? paperUrl,
            global::G.ModelsCreateRequestVisibility visibility,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Hardware { get; } = new(
            name: "hardware")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.ModelsCreateRequestVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> CoverImageUrl { get; } = new(
            name: "coverImageUrl")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> GithubUrl { get; } = new(
            name: "githubUrl")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> LicenseUrl { get; } = new(
            name: "licenseUrl")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> PaperUrl { get; } = new(
            name: "paperUrl")
        {
            Description = @"",
        };
        public CreateModelsCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a model.

Example cURL request:

```console
curl -s -X POST \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  -H 'Content-Type: application/json' \
  -d '{""owner"": ""alice"", ""name"": ""my-model"", ""description"": ""An example model"", ""visibility"": ""public"", ""hardware"": ""cpu""}' \
  https://api.replicate.com/v1/models
```

The response will be a model object in the following format:

```json
{
  ""url"": ""https://replicate.com/alice/my-model"",
  ""owner"": ""alice"",
  ""name"": ""my-model"",
  ""description"": ""An example model"",
  ""visibility"": ""public"",
  ""github_url"": null,
  ""paper_url"": null,
  ""license_url"": null,
  ""run_count"": 0,
  ""cover_image_url"": null,
  ""default_example"": null,
  ""latest_version"": null,
}
```

Note that there is a limit of 1,000 models per account. For most purposes, we recommend using a single model and pushing new [versions](https://replicate.com/docs/how-does-replicate-work#versions) of the model as you make changes to it.")
        {
            _client = client;

            Arguments.Add(Hardware);
            Arguments.Add(Name);
            Arguments.Add(Owner);
            Arguments.Add(Visibility);
            Options.Add(CoverImageUrl);
            Options.Add(Description);
            Options.Add(GithubUrl);
            Options.Add(LicenseUrl);
            Options.Add(PaperUrl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var coverImageUrl = parseResult.GetRequiredValue(CoverImageUrl);
            var description = parseResult.GetRequiredValue(Description);
            var githubUrl = parseResult.GetRequiredValue(GithubUrl);
            var hardware = parseResult.GetRequiredValue(Hardware);
            var licenseUrl = parseResult.GetRequiredValue(LicenseUrl);
            var name = parseResult.GetRequiredValue(Name);
            var owner = parseResult.GetRequiredValue(Owner);
            var paperUrl = parseResult.GetRequiredValue(PaperUrl);
            var visibility = parseResult.GetRequiredValue(Visibility);

            Validate(
                parseResult: parseResult,
                coverImageUrl: coverImageUrl,
                description: description,
                githubUrl: githubUrl,
                hardware: hardware,
                licenseUrl: licenseUrl,
                name: name,
                owner: owner,
                paperUrl: paperUrl,
                visibility: visibility,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CreateModelsAsync(
                coverImageUrl: coverImageUrl,
                description: description,
                githubUrl: githubUrl,
                hardware: hardware,
                licenseUrl: licenseUrl,
                name: name,
                owner: owner,
                paperUrl: paperUrl,
                visibility: visibility,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}