//HintName: G.Commands.FilesGetMultipartUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FilesGetMultipartUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid uploadId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MultipartUploadDetailResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> UploadId { get; } = new(
            name: "uploadId")
        {
            Description = @"The ID of the multipart upload",
        };



        public FilesGetMultipartUploadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a multipart upload's details with fresh presigned URLs for any parts not yet uploaded.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UploadId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uploadId = parseResult.GetRequiredValue(UploadId);

            Validate(
                parseResult: parseResult,
                uploadId: uploadId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Files.GetMultipartUploadAsync(
                uploadId: uploadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}