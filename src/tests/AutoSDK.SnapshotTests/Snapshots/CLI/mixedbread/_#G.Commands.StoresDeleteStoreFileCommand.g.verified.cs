//HintName: G.Commands.StoresDeleteStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresDeleteStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreFileDeleted response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> FileIdentifier { get; } = new(
            name: "fileIdentifier")
        {
            Description = @"The ID or name of the file to delete",
        };



        public StoresDeleteStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete a file from a store.

Args:
    store_identifier: The ID or name of the store.
    file_id: The ID or name of the file to delete.

Returns:
    VectorStoreFileDeleted: The deleted file details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(FileIdentifier);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var fileIdentifier = parseResult.GetRequiredValue(FileIdentifier);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.DeleteStoreFileAsync(
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}