//HintName: G.Commands.UploadCatalogFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadCatalogFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            string name,
            global::G.FileType type,
            string? content,
            object? externalMetadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UploadCatalogFileResponse response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.FileType> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Content { get; } = new(
            name: "content")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> ExternalMetadata { get; } = new(
            name: "externalMetadata")
        {
            Description = @"",
        };
        public UploadCatalogFileCommand(G.IApi client) : base(
            name: "upload",
            description: @"Creates a file.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Arguments.Add(Name);
            Arguments.Add(Type);
            Options.Add(Content);
            Options.Add(ExternalMetadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var content = parseResult.GetRequiredValue(Content);
            var externalMetadata = parseResult.GetRequiredValue(ExternalMetadata);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                name: name,
                type: type,
                content: content,
                externalMetadata: externalMetadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.UploadCatalogFileAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                name: name,
                type: type,
                content: content,
                externalMetadata: externalMetadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}