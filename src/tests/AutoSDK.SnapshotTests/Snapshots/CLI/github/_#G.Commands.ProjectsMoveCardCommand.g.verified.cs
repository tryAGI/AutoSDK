//HintName: G.Commands.ProjectsMoveCardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsMoveCardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int cardId,
            string position,
            int? columnId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectsMoveCardResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> CardId { get; } = new(
            name: "cardId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Position { get; } = new(
            name: "position")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> ColumnId { get; } = new(
            name: "columnId")
        {
            Description = "",
        };
        public ProjectsMoveCardCommand(G.IApi client) : base(
            name: "projects",
            description: @"")
        {
            _client = client;

            Arguments.Add(CardId);
            Arguments.Add(Position);
            Options.Add(ColumnId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cardId = parseResult.GetRequiredValue(CardId);
            var position = parseResult.GetRequiredValue(Position);
            var columnId = parseResult.GetRequiredValue(ColumnId);

            Validate(
                parseResult: parseResult,
                cardId: cardId,
                position: position,
                columnId: columnId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsMoveCardAsync(
                cardId: cardId,
                position: position,
                columnId: columnId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}