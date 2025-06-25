//HintName: G.Commands.ProjectsDeleteColumnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsDeleteColumnCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int columnId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ColumnId { get; } = new(
            name: "columnId")
        {
            Description = "",
        };

        public ProjectsDeleteColumnCommand(G.IApi client) : base(
            name: "projects",
            description: @"Deletes a project column.")
        {
            _client = client;

            Arguments.Add(ColumnId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var columnId = parseResult.GetRequiredValue(ColumnId);

            Validate(
                parseResult: parseResult,
                columnId: columnId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Projects.ProjectsDeleteColumnAsync(
                columnId: columnId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}