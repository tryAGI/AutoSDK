//HintName: G.Commands.ListOperationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListOperationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? pageToken,
            int? pageSize,
            string? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListOperationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"The token identifying which page to start with.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The list page size.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"The filters to apply.",
        };
        public ListOperationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageToken);
            Options.Add(PageSize);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                pageToken: pageToken,
                pageSize: pageSize,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListOperationsAsync(
                pageToken: pageToken,
                pageSize: pageSize,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}