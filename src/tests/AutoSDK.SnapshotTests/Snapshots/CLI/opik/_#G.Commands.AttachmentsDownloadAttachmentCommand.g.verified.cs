//HintName: G.Commands.AttachmentsDownloadAttachmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentsDownloadAttachmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? workspaceName,
            global::System.Guid containerId,
            global::G.DownloadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string fileName,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ContainerId { get; } = new(
            name: "containerId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.DownloadAttachmentEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> EntityId { get; } = new(
            name: "entityId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> FileName { get; } = new(
            name: "fileName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> WorkspaceName { get; } = new(
            name: "workspaceName")
        {
            Description = @"",
        };


        public AttachmentsDownloadAttachmentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "download",
            description: @"Download attachment from MinIO")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ContainerId);
            Arguments.Add(EntityType);
            Arguments.Add(EntityId);
            Arguments.Add(FileName);
            Arguments.Add(MimeType);
            Options.Add(WorkspaceName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var workspaceName = parseResult.GetRequiredValue(WorkspaceName);
            var containerId = parseResult.GetRequiredValue(ContainerId);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var entityId = parseResult.GetRequiredValue(EntityId);
            var fileName = parseResult.GetRequiredValue(FileName);
            var mimeType = parseResult.GetRequiredValue(MimeType);

            Validate(
                parseResult: parseResult,
                workspaceName: workspaceName,
                containerId: containerId,
                entityType: entityType,
                entityId: entityId,
                fileName: fileName,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Attachments.DownloadAttachmentAsync(
                workspaceName: workspaceName,
                containerId: containerId,
                entityType: entityType,
                entityId: entityId,
                fileName: fileName,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}