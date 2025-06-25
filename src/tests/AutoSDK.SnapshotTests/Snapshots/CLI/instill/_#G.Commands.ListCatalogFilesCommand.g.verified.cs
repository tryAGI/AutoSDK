//HintName: G.Commands.ListCatalogFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListCatalogFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.IList<string>? filterFileUids,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListCatalogFilesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> FilterFileUids { get; } = new(
            name: "filterFileUids")
        {
            Description = @"",
        };
        public ListCatalogFilesCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a paginated list of catalog files.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(FilterFileUids);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var filterFileUids = parseResult.GetRequiredValue(FilterFileUids);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                pageSize: pageSize,
                pageToken: pageToken,
                filterFileUids: filterFileUids,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.ListCatalogFilesAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                pageSize: pageSize,
                pageToken: pageToken,
                filterFileUids: filterFileUids,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}