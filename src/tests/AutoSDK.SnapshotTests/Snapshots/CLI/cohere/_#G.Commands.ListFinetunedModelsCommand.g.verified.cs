//HintName: G.Commands.ListFinetunedModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListFinetunedModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            string? orderBy,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListFinetunedModelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


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
        public ListFinetunedModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                orderBy: orderBy,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Finetuning.ListFinetunedModelsAsync(
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