//HintName: G.Commands.StoresUpdateStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresUpdateStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            object? metadata,
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

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> FileIdentifier { get; } = new(
            name: "fileIdentifier")
        {
            Description = @"The ID or name of the file to update",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Updated metadata for the file",
        };


        public StoresUpdateStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update metadata on a file within a store.

Args:
    store_identifier: The ID or name of the store.
    file_identifier: The ID or name of the file to update.
    update_params: Metadata update payload.

Returns:
    StoreFile: The updated file details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(FileIdentifier);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var fileIdentifier = parseResult.GetRequiredValue(FileIdentifier);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.UpdateStoreFileAsync(
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}