//HintName: G.Commands.FilesCreateMultipartUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FilesCreateMultipartUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string filename,
            long fileSize,
            string mimeType,
            int? partCount,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateMultipartUploadResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"Name of the file including extension",
        };

        private global::System.CommandLine.Argument<long> FileSize { get; } = new(
            name: "fileSize")
        {
            Description = @"Total size of the file in bytes",
        };

        private global::System.CommandLine.Argument<string> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = @"MIME type of the file",
        };

        private global::System.CommandLine.Option<int?> PartCount { get; } = new(
            name: "partCount")
        {
            Description = @"Number of parts to split the upload into",
        };


        public FilesCreateMultipartUploadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Initiate a multipart upload and receive presigned URLs for uploading parts directly to storage.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Filename);
            Arguments.Add(FileSize);
            Arguments.Add(MimeType);
            Options.Add(PartCount);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filename = parseResult.GetRequiredValue(Filename);
            var fileSize = parseResult.GetRequiredValue(FileSize);
            var mimeType = parseResult.GetRequiredValue(MimeType);
            var partCount = parseResult.GetRequiredValue(PartCount);

            Validate(
                parseResult: parseResult,
                filename: filename,
                fileSize: fileSize,
                mimeType: mimeType,
                partCount: partCount,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Files.CreateMultipartUploadAsync(
                filename: filename,
                fileSize: fileSize,
                mimeType: mimeType,
                partCount: partCount,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}