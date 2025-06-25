//HintName: G.Commands.ListHardwareCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListHardwareCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.HardwareListResponseItem> response,
            global::System.Threading.CancellationToken cancellationToken);


        public ListHardwareCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/hardware
```

The response will be a JSON array of hardware objects:

```json
[
    {""name"": ""CPU"", ""sku"": ""cpu""},
    {""name"": ""Nvidia T4 GPU"", ""sku"": ""gpu-t4""},
    {""name"": ""Nvidia A40 GPU"", ""sku"": ""gpu-a40-small""},
    {""name"": ""Nvidia A40 (Large) GPU"", ""sku"": ""gpu-a40-large""},
]
```")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListHardwareAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}