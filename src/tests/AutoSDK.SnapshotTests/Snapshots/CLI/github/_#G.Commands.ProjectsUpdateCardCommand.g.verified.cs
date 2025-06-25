//HintName: G.Commands.ProjectsUpdateCardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsUpdateCardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int cardId,
            string? note,
            bool? archived,
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

        private global::System.CommandLine.Option<string?> Note { get; } = new(
            name: "note")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Archived { get; } = new(
            name: "archived")
        {
            Description = "",
        };
        public ProjectsUpdateCardCommand(G.IApi client) : base(
            name: "projects",
            description: @"")
        {
            _client = client;

            Arguments.Add(CardId);
            Options.Add(Note);
            Options.Add(Archived);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cardId = parseResult.GetRequiredValue(CardId);
            var note = parseResult.GetRequiredValue(Note);
            var archived = parseResult.GetRequiredValue(Archived);

            Validate(
                parseResult: parseResult,
                cardId: cardId,
                note: note,
                archived: archived,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsUpdateCardAsync(
                cardId: cardId,
                note: note,
                archived: archived,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}