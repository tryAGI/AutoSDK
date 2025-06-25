//HintName: G.Commands.ProjectsDeleteCardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsDeleteCardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int cardId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> CardId { get; } = new(
            name: "cardId")
        {
            Description = "",
        };

        public ProjectsDeleteCardCommand(G.IApi client) : base(
            name: "projects",
            description: @"Deletes a project card")
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
            await _client.Projects.ProjectsDeleteCardAsync(
                cardId: cardId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}