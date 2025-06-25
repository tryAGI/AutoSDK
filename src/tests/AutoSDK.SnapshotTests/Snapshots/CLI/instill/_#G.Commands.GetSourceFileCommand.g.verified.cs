//HintName: G.Commands.GetSourceFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetSourceFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetSourceFileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"owner/namespace id",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"catalog id",
        };

        private global::System.CommandLine.Argument<string> FileUid { get; } = new(
            name: "fileUid")
        {
            Description = @"unique identifier of the original uploaded file",
        };

        public GetSourceFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets the single-source-of-truth file of a catalog.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);
            Arguments.Add(FileUid);

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

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.GetSourceFileAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}