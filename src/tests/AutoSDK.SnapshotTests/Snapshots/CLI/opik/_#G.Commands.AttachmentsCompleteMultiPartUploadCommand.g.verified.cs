//HintName: G.Commands.AttachmentsCompleteMultiPartUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentsCompleteMultiPartUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileName,
            string? projectName,
            global::G.CompleteMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            long fileSize,
            string? mimeType,
            string uploadId,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> uploadedFileParts,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileName { get; } = new(
            name: "fileName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.CompleteMultipartUploadRequestEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> EntityId { get; } = new(
            name: "entityId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<long> FileSize { get; } = new(
            name: "fileSize")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> UploadId { get; } = new(
            name: "uploadId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.MultipartUploadPart>> UploadedFileParts { get; } = new(
            name: "uploadedFileParts")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If null, the default project is used",
        };

        private global::System.CommandLine.Option<string?> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = @"",
        };


        public AttachmentsCompleteMultiPartUploadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "complete",
            description: @"Complete multipart attachment upload")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileName);
            Arguments.Add(EntityType);
            Arguments.Add(EntityId);
            Arguments.Add(FileSize);
            Arguments.Add(UploadId);
            Arguments.Add(UploadedFileParts);
            Options.Add(ProjectName);
            Options.Add(MimeType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileName = parseResult.GetRequiredValue(FileName);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var entityId = parseResult.GetRequiredValue(EntityId);
            var fileSize = parseResult.GetRequiredValue(FileSize);
            var mimeType = parseResult.GetRequiredValue(MimeType);
            var uploadId = parseResult.GetRequiredValue(UploadId);
            var uploadedFileParts = parseResult.GetRequiredValue(UploadedFileParts);

            Validate(
                parseResult: parseResult,
                fileName: fileName,
                projectName: projectName,
                entityType: entityType,
                entityId: entityId,
                fileSize: fileSize,
                mimeType: mimeType,
                uploadId: uploadId,
                uploadedFileParts: uploadedFileParts,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Attachments.CompleteMultiPartUploadAsync(
                fileName: fileName,
                projectName: projectName,
                entityType: entityType,
                entityId: entityId,
                fileSize: fileSize,
                mimeType: mimeType,
                uploadId: uploadId,
                uploadedFileParts: uploadedFileParts,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}