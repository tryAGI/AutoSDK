//HintName: G.Commands.ListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? pageToken,
            int? pageSize,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelsResponse response,
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
        public ListModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Lists models available through the API.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageToken);
            Options.Add(PageSize);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var pageSize = parseResult.GetRequiredValue(PageSize);

            Validate(
                parseResult: parseResult,
                pageToken: pageToken,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListModelsAsync(
                pageToken: pageToken,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}