//HintName: G.Commands.AttachmentsUploadAttachmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentsUploadAttachmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileName,
            string? projectName,
            string? mimeType,
            global::G.UploadAttachmentEntityType entityType,
            global::System.Guid entityId,

            byte[] request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileName { get; } = new(
            name: "fileName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.UploadAttachmentEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> EntityId { get; } = new(
            name: "entityId")
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


        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
        };


        public AttachmentsUploadAttachmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "upload",
            description: @"Upload attachment to MinIO")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileName);
            Arguments.Add(EntityType);
            Arguments.Add(EntityId);
            Options.Add(ProjectName);
            Options.Add(MimeType);

            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileName = parseResult.GetRequiredValue(FileName);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var mimeType = parseResult.GetRequiredValue(MimeType);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var entityId = parseResult.GetRequiredValue(EntityId);

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<byte[]>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Attachments.UploadAttachmentAsync(
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}