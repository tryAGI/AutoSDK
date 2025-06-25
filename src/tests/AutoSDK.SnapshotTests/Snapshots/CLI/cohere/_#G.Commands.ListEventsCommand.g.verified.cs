//HintName: G.Commands.ListEventsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListEventsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string finetunedModelId,
            int? pageSize,
            string? pageToken,
            string? orderBy,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListEventsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FinetunedModelId { get; } = new(
            name: "finetunedModelId")
        {
            Description = @"The parent fine-tuned model ID.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"Maximum number of results to be returned by the server. If 0, defaults to
50.",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Request a specific page of the list results.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Comma separated list of fields. For example: ""created_at,name"". The default
sorting order is ascending. To specify descending order for a field, append
"" desc"" to the field name. For example: ""created_at desc,name"".

Supported sorting fields:
  - created_at (default)",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public ListEventsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FinetunedModelId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(OrderBy);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var finetunedModelId = parseResult.GetRequiredValue(FinetunedModelId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                finetunedModelId: finetunedModelId,
                pageSize: pageSize,
                pageToken: pageToken,
                orderBy: orderBy,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Finetuning.ListEventsAsync(
                finetunedModelId: finetunedModelId,
                pageSize: pageSize,
                pageToken: pageToken,
                orderBy: orderBy,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}