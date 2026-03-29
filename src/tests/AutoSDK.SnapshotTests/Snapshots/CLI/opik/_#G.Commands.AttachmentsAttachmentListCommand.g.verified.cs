//HintName: G.Commands.AttachmentsAttachmentListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentsAttachmentListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            global::System.Guid projectId,
            global::G.AttachmentListEntityType entityType,
            global::System.Guid entityId,
            string path,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AttachmentPage response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.AttachmentListEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> EntityId { get; } = new(
            name: "entityId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Path { get; } = new(
            name: "path")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };


        public AttachmentsAttachmentListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "attachment",
            description: @"Attachments list for entity")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Arguments.Add(EntityType);
            Arguments.Add(EntityId);
            Arguments.Add(Path);
            Options.Add(Page);
            Options.Add(Size);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var entityId = parseResult.GetRequiredValue(EntityId);
            var path = parseResult.GetRequiredValue(Path);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                projectId: projectId,
                entityType: entityType,
                entityId: entityId,
                path: path,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Attachments.AttachmentListAsync(
                page: page,
                size: size,
                projectId: projectId,
                entityType: entityType,
                entityId: entityId,
                path: path,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}