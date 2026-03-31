//HintName: G.Commands.FilesUploadFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FilesUploadFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.CreateFileRequestPurpose purpose,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.File response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"The File object (not file name) to be uploaded.",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The File object (not file name) to be uploaded.",
        };

        private global::System.CommandLine.Option<global::G.CreateFileRequestPurpose> Purpose { get; } = new(
            name: "purpose")
        {
            Description = @"The intended purpose of the uploaded file.
Use ""batch"" for [Batch API](/docs/api-reference#batches).",
        };


        public FilesUploadFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "upload",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Options.Add(Purpose);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var purpose = parseResult.GetRequiredValue(Purpose);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Files.UploadFileAsync(
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}