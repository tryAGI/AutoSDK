//HintName: G.Commands.AttachmentsStartMultiPartUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentsStartMultiPartUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileName,
            int numOfFileParts,
            string? mimeType,
            string? projectName,
            global::G.StartMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            string path,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StartMultipartUploadResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileName { get; } = new(
            name: "fileName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> NumOfFileParts { get; } = new(
            name: "numOfFileParts")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.StartMultipartUploadRequestEntityType> EntityType { get; } = new(
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

        private global::System.CommandLine.Option<string?> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"If null, the default project is used",
        };


        public AttachmentsStartMultiPartUploadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "start",
            description: @"Start multipart attachment upload")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileName);
            Arguments.Add(NumOfFileParts);
            Arguments.Add(EntityType);
            Arguments.Add(EntityId);
            Arguments.Add(Path);
            Options.Add(MimeType);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileName = parseResult.GetRequiredValue(FileName);
            var numOfFileParts = parseResult.GetRequiredValue(NumOfFileParts);
            var mimeType = parseResult.GetRequiredValue(MimeType);
            var projectName = parseResult.GetRequiredValue(ProjectName);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var entityId = parseResult.GetRequiredValue(EntityId);
            var path = parseResult.GetRequiredValue(Path);

            Validate(
                parseResult: parseResult,
                fileName: fileName,
                numOfFileParts: numOfFileParts,
                mimeType: mimeType,
                projectName: projectName,
                entityType: entityType,
                entityId: entityId,
                path: path,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Attachments.StartMultiPartUploadAsync(
                fileName: fileName,
                numOfFileParts: numOfFileParts,
                mimeType: mimeType,
                projectName: projectName,
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