//HintName: G.Commands.FilesCompleteMultipartUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FilesCompleteMultipartUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid uploadId,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> parts,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FileObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> UploadId { get; } = new(
            name: "uploadId")
        {
            Description = @"The ID of the multipart upload",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.MultipartUploadPart>> Parts { get; } = new(
            name: "parts")
        {
            Description = @"List of completed parts with their ETags",
        };



        public FilesCompleteMultipartUploadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "complete",
            description: @"Complete a multipart upload after all parts have been uploaded.
Creates the file object and returns it.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UploadId);
            Arguments.Add(Parts);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uploadId = parseResult.GetRequiredValue(UploadId);
            var parts = parseResult.GetRequiredValue(Parts);

            Validate(
                parseResult: parseResult,
                uploadId: uploadId,
                parts: parts,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Files.CompleteMultipartUploadAsync(
                uploadId: uploadId,
                parts: parts,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}