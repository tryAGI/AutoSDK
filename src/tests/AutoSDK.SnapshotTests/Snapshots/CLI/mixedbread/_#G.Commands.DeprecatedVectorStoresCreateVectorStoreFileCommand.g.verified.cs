//HintName: G.Commands.DeprecatedVectorStoresCreateVectorStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresCreateVectorStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            object? metadata,
            global::G.StoreFileConfig2? config,
            string? externalId,
            bool? overwrite,
            global::System.Guid fileId,
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

        private global::System.CommandLine.Argument<global::System.Guid> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"ID of the file to add",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional metadata for the file",
        };

        private global::System.CommandLine.Option<global::G.StoreFileConfig2?> Config { get; } = new(
            name: "config")
        {
            Description = @"Configuration for adding the file",
        };

        private global::System.CommandLine.Option<string?> ExternalId { get; } = new(
            name: "externalId")
        {
            Description = @"External identifier for this file in the store",
        };

        private global::System.CommandLine.Option<bool?> Overwrite { get; } = new(
            name: "overwrite")
        {
            Description = @"If true, overwrite an existing file with the same external_id",
        };


        public DeprecatedVectorStoresCreateVectorStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"DEPRECATED: Use POST /stores/{store_identifier}/files instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Arguments.Add(FileId);
            Options.Add(Metadata);
            Options.Add(Config);
            Options.Add(ExternalId);
            Options.Add(Overwrite);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var config = parseResult.GetRequiredValue(Config);
            var externalId = parseResult.GetRequiredValue(ExternalId);
            var overwrite = parseResult.GetRequiredValue(Overwrite);
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                metadata: metadata,
                config: config,
                externalId: externalId,
                overwrite: overwrite,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.CreateVectorStoreFileAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                metadata: metadata,
                config: config,
                externalId: externalId,
                overwrite: overwrite,
                fileId: fileId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}