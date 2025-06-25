//HintName: G.Commands.EditProjectsByProjectIdChaptersByChapterIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditProjectsByProjectIdChaptersByChapterIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string chapterId,
            string? xiApiKey,
            string? name,
            global::G.ChapterContentInputModel? content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EditChapterResponseModel response,
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

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChapterContentInputModel?> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };
        public EditProjectsByProjectIdChaptersByChapterIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Edits a chapter.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ChapterId);
            Options.Add(XiApiKey);
            Options.Add(Name);
            Options.Add(Content);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var chapterId = parseResult.GetRequiredValue(ChapterId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey,
                name: name,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.EditProjectsByProjectIdChaptersByChapterIdAsync(
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey,
                name: name,
                content: content,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}