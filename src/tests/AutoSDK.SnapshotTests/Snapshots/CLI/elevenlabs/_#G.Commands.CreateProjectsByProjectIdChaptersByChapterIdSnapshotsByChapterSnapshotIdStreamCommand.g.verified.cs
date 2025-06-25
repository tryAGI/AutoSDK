//HintName: G.Commands.CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string chapterId,
            string chapterSnapshotId,
            string? xiApiKey,
            bool? convertToMpeg,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ChapterId { get; } = new(
            name: "chapterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ChapterSnapshotId { get; } = new(
            name: "chapterSnapshotId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ConvertToMpeg { get; } = new(
            name: "convertToMpeg")
        {
            Description = "",
        };
        public CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamCommand(G.IApi client) : base(
            name: "create",
            description: @"Stream the audio from a chapter snapshot. Use `GET /v1/projects/{project_id}/chapters/{chapter_id}/snapshots` to return the chapter snapshots of a chapter.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ChapterId);
            Arguments.Add(ChapterSnapshotId);
            Options.Add(XiApiKey);
            Options.Add(ConvertToMpeg);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var chapterId = parseResult.GetRequiredValue(ChapterId);
            var chapterSnapshotId = parseResult.GetRequiredValue(ChapterSnapshotId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var convertToMpeg = parseResult.GetRequiredValue(ConvertToMpeg);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                chapterId: chapterId,
                chapterSnapshotId: chapterSnapshotId,
                xiApiKey: xiApiKey,
                convertToMpeg: convertToMpeg,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.CreateProjectsByProjectIdChaptersByChapterIdSnapshotsByChapterSnapshotIdStreamAsync(
                projectId: projectId,
                chapterId: chapterId,
                chapterSnapshotId: chapterSnapshotId,
                xiApiKey: xiApiKey,
                convertToMpeg: convertToMpeg,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}