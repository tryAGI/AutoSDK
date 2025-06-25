//HintName: G.Commands.PipelinePublicServiceListIntegrationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListIntegrationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            string? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListIntegrationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of items to return. The default and cap values are 10 and 100, respectively.",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token. By default, the first page will be returned.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter expression.
The following filters are supported:
- `qIntegration` (fuzzy search on title or vendor)

**Examples**:
- List integrations where app name or vendor match `googl`: `q=""googl""`.",
        };
        public PipelinePublicServiceListIntegrationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns a paginated list of available integrations.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListIntegrationsAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}