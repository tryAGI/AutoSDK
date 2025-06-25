//HintName: G.Commands.DeleteStudioProjectsByProjectIdChaptersByChapterIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteStudioProjectsByProjectIdChaptersByChapterIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string chapterId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteChapterResponseModel response,
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
        public DeleteStudioProjectsByProjectIdChaptersByChapterIdCommand(G.IApi client) : base(
            name: "delete",
            description: @"Deletes a chapter.")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(ChapterId);
            Options.Add(XiApiKey);

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

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Studio.DeleteStudioProjectsByProjectIdChaptersByChapterIdAsync(
                projectId: projectId,
                chapterId: chapterId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}