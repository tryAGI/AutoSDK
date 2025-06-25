//HintName: G.Commands.ProjectsGetCardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetCardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int cardId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectCard response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> CardId { get; } = new(
            name: "cardId")
        {
            Description = "",
        };

        public ProjectsGetCardCommand(G.IApi client) : base(
            name: "projects",
            description: @"Gets information about a project card.")
        {
            _client = client;

            Arguments.Add(CardId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cardId = parseResult.GetRequiredValue(CardId);

            Validate(
                parseResult: parseResult,
                cardId: cardId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsGetCardAsync(
                cardId: cardId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}