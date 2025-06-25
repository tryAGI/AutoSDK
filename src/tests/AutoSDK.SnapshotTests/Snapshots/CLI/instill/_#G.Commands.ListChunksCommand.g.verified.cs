//HintName: G.Commands.ListChunksCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListChunksCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            string? fileUid,
            global::System.Collections.Generic.IList<string>? chunkUids,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListChunksResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FileUid { get; } = new(
            name: "fileUid")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ChunkUids { get; } = new(
            name: "chunkUids")
        {
            Description = "",
        };
        public ListChunksCommand(G.IApi client) : base(
            name: "list",
            description: @"Returns a paginated list of catalog chunks.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Options.Add(FileUid);
            Options.Add(ChunkUids);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var fileUid = parseResult.GetRequiredValue(FileUid);
            var chunkUids = parseResult.GetRequiredValue(ChunkUids);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileUid: fileUid,
                chunkUids: chunkUids,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.ListChunksAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileUid: fileUid,
                chunkUids: chunkUids,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}