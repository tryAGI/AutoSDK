//HintName: G.Commands.GetFileCatalogCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetFileCatalogCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            string? fileId,
            string? fileUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetFileCatalogResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"id of the namespace",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"id of the catalog",
        };

        private global::System.CommandLine.Option<string?> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"id of the file(i.e. file name)",
        };

        private global::System.CommandLine.Option<string?> FileUid { get; } = new(
            name: "fileUid")
        {
            Description = @"Uid of the file",
        };
        public GetFileCatalogCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get the catalog file.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Options.Add(FileId);
            Options.Add(FileUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var fileId = parseResult.GetRequiredValue(FileId);
            var fileUid = parseResult.GetRequiredValue(FileUid);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileId: fileId,
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.GetFileCatalogAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileId: fileId,
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}