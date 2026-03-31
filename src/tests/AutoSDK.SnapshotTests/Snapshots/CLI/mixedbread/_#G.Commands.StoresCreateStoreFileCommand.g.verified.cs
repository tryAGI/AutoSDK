//HintName: G.Commands.StoresCreateStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresCreateStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            object? metadata,
            global::G.StoreFileConfig2? config,
            string? externalId,
            bool? overwrite,
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreFile response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
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


        public StoresCreateStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Upload a file to a store.

Args:
    store_identifier: The ID or name of the store.
    file_add_params: The file to add to the store.

Returns:
    VectorStoreFile: The uploaded file details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
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
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var config = parseResult.GetRequiredValue(Config);
            var externalId = parseResult.GetRequiredValue(ExternalId);
            var overwrite = parseResult.GetRequiredValue(Overwrite);
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                metadata: metadata,
                config: config,
                externalId: externalId,
                overwrite: overwrite,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.CreateStoreFileAsync(
                storeIdentifier: storeIdentifier,
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