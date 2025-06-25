//HintName: G.Commands.DeleteCatalogCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteCatalogCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string catalogId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteCatalogResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The owner's id. i.e. namespace.",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"The catalog id.",
        };

        public DeleteCatalogCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes a catalog.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(CatalogId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                catalogId: catalogId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.DeleteCatalogAsync(
                namespaceId: namespaceId,
                catalogId: catalogId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}