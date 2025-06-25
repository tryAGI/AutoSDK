//HintName: G.Commands.ListTokensCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListTokensCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListTokensResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of tokens to return. If this parameter is unspecified,
at most 10 pipelines will be returned. The cap value for this parameter is
100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token.",
        };
        public ListTokensCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a paginated list of the API tokens of the authenticated user.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageSize);
            Options.Add(PageToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.ListTokensAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}