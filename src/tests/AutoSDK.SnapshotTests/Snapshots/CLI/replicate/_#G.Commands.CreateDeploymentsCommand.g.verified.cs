//HintName: G.Commands.CreateDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string hardware,
            int maxInstances,
            int minInstances,
            string model,
            string name,
            string version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentsCreateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Hardware { get; } = new(
            name: "hardware")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> MaxInstances { get; } = new(
            name: "maxInstances")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> MinInstances { get; } = new(
            name: "minInstances")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Version { get; } = new(
            name: "version")
        {
            Description = "",
        };

        public CreateDeploymentsCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a new deployment:

Example cURL request:

```console
curl -s \
  -X POST \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  -H ""Content-Type: application/json"" \
  -d '{
        ""name"": ""my-app-image-generator"",
        ""model"": ""stability-ai/sdxl"",
        ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
        ""hardware"": ""gpu-t4"",
        ""min_instances"": 0,
        ""max_instances"": 3
      }' \
  https://api.replicate.com/v1/deployments
```

The response will be a JSON object describing the deployment:

```json
{
  ""owner"": ""acme"",
  ""name"": ""my-app-image-generator"",
  ""current_release"": {
    ""number"": 1,
    ""model"": ""stability-ai/sdxl"",
    ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
    ""created_at"": ""2024-02-15T16:32:57.018467Z"",
    ""created_by"": {
      ""type"": ""organization"",
      ""username"": ""acme"",
      ""name"": ""Acme Corp, Inc."",
      ""github_url"": ""https://github.com/acme"",
    },
    ""configuration"": {
      ""hardware"": ""gpu-t4"",
      ""min_instances"": 1,
      ""max_instances"": 5
    }
  }
}
```
")
        {
            _client = client;

            Arguments.Add(Hardware);
            Arguments.Add(MaxInstances);
            Arguments.Add(MinInstances);
            Arguments.Add(Model);
            Arguments.Add(Name);
            Arguments.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var hardware = parseResult.GetRequiredValue(Hardware);
            var maxInstances = parseResult.GetRequiredValue(MaxInstances);
            var minInstances = parseResult.GetRequiredValue(MinInstances);
            var model = parseResult.GetRequiredValue(Model);
            var name = parseResult.GetRequiredValue(Name);
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                hardware: hardware,
                maxInstances: maxInstances,
                minInstances: minInstances,
                model: model,
                name: name,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateDeploymentsAsync(
                hardware: hardware,
                maxInstances: maxInstances,
                minInstances: minInstances,
                model: model,
                name: name,
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}