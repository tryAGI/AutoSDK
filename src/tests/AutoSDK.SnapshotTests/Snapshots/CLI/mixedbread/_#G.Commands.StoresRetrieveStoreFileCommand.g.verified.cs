//HintName: G.Commands.StoresRetrieveStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresRetrieveStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::G.AnyOf<bool?, global::System.Collections.Generic.IList<int>>? returnChunks,
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
            Description = @"The ID or name of the file",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<bool?, global::System.Collections.Generic.IList<int>>?> ReturnChunks { get; } = new(
            name: "returnChunks")
        {
            Description = @"Whether to return the chunks for the file. If a list of integers is provided, only the chunks at the specified indices will be returned.",
        };


        public StoresRetrieveStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "retrieve",
            description: @"Get a file from a store.

Args:
    store_identifier: The ID or name of the store.
    file_id: The ID or name of the file.
    options: Get file options.

Returns:
    VectorStoreFile: The file details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(FileIdentifier);
            Options.Add(ReturnChunks);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var fileIdentifier = parseResult.GetRequiredValue(FileIdentifier);
            var returnChunks = parseResult.GetRequiredValue(ReturnChunks);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                returnChunks: returnChunks,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.RetrieveStoreFileAsync(
                storeIdentifier: storeIdentifier,
                fileIdentifier: fileIdentifier,
                returnChunks: returnChunks,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}