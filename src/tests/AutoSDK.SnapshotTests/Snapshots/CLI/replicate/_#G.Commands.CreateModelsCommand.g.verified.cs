//HintName: G.Commands.CreateModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the model. This must be unique among all models owned by the user or organization.",
        };

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.",
        };

        private global::System.CommandLine.Argument<global::G.ModelsCreateRequestVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.",
        };

        private global::System.CommandLine.Option<string?> CoverImageUrl { get; } = new(
            name: "coverImageUrl")
        {
            Description = @"A URL for the model's cover image. This should be an image file.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A description of the model.",
        };

        private global::System.CommandLine.Option<string?> GithubUrl { get; } = new(
            name: "githubUrl")
        {
            Description = @"A URL for the model's source code on GitHub.",
        };

        private global::System.CommandLine.Option<string?> LicenseUrl { get; } = new(
            name: "licenseUrl")
        {
            Description = @"A URL for the model's license.",
        };

        private global::System.CommandLine.Option<string?> PaperUrl { get; } = new(
            name: "paperUrl")
        {
            Description = @"A URL for the model's paper.",
        };
        public CreateModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
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
            _serviceProvider = serviceProvider;

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