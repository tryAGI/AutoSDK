//HintName: G.Commands.ProjectsMoveColumnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsMoveColumnCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int columnId,
            string position,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectsMoveColumnResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ColumnId { get; } = new(
            name: "columnId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Position { get; } = new(
            name: "position")
        {
            Description = "",
        };

        public ProjectsMoveColumnCommand(G.IApi client) : base(
            name: "projects",
            description: @"")
        {
            _client = client;

            Arguments.Add(ColumnId);
            Arguments.Add(Position);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var columnId = parseResult.GetRequiredValue(ColumnId);
            var position = parseResult.GetRequiredValue(Position);

            Validate(
                parseResult: parseResult,
                columnId: columnId,
                position: position,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsMoveColumnAsync(
                columnId: columnId,
                position: position,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}