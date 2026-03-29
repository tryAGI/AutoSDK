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

            Validate(
                parseResult: parseResult,
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Attachments.UploadAttachmentAsync(
                fileName: fileName,
                projectName: projectName,
                mimeType: mimeType,
                entityType: entityType,
                entityId: entityId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}