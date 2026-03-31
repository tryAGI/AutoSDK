//HintName: G.Commands.DeprecatedVectorStoresDeleteVectorStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresDeleteVectorStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VectorStoreFileDeleted response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifier { get; } = new(
            name: "vectorStoreIdentifier")
        {
            Description = @"The ID or name of the vector store",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The ID or name of the file to delete",
        };



        public DeprecatedVectorStoresDeleteVectorStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"DEPRECATED: Use DELETE /stores/{store_identifier}/files/{file_id} instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Arguments.Add(FileId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.DeleteVectorStoreFileAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                fileId: fileId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}