//HintName: G.Commands.DeprecatedVectorStoresRetrieveVectorStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresRetrieveVectorStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileId,
            bool? returnChunks,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VectorStoreFile response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifier { get; } = new(
            name: "vectorStoreIdentifier")
        {
            Description = @"The ID or name of the vector store",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The ID or name of the file",
        };

        private global::System.CommandLine.Option<bool?> ReturnChunks { get; } = new(
            name: "returnChunks")
        {
            Description = @"Whether to return the chunks for the file",
        };


        public DeprecatedVectorStoresRetrieveVectorStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"DEPRECATED: Use GET /stores/{store_identifier}/files/{file_id} instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Arguments.Add(FileId);
            Options.Add(ReturnChunks);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var fileId = parseResult.GetRequiredValue(FileId);
            var returnChunks = parseResult.GetRequiredValue(ReturnChunks);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                fileId: fileId,
                returnChunks: returnChunks,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.RetrieveVectorStoreFileAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                fileId: fileId,
                returnChunks: returnChunks,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}