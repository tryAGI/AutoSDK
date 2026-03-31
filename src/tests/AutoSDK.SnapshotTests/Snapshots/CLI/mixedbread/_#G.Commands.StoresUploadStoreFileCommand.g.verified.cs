//HintName: G.Commands.StoresUploadStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresUploadStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            byte[] file,
            string filename,
            string? @params,
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

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"The file to upload and index",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The file to upload and index",
        };

        private global::System.CommandLine.Option<string?> Params { get; } = new(
            name: "@params")
        {
            Description = @"",
        };


        public StoresUploadStoreFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "upload",
            description: @"Upload a file via form to a store.

Args:
    store_identifier: The ID or name of the store.
    config: The config for the file.
    metadata: The metadata for the file.
    file: The file to upload.

Returns:
    VectorStoreFile: The uploaded file details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Arguments.Add(File);
            Arguments.Add(Filename);
            Options.Add(Params);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var @params = parseResult.GetRequiredValue(Params);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                file: file,
                filename: filename,
                @params: @params,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.UploadStoreFileAsync(
                storeIdentifier: storeIdentifier,
                file: file,
                filename: filename,
                @params: @params,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}