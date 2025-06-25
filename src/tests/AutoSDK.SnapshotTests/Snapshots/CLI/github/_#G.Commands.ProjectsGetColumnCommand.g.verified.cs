//HintName: G.Commands.ProjectsGetColumnCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetColumnCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int columnId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectColumn response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ColumnId { get; } = new(
            name: "columnId")
        {
            Description = "",
        };

        public ProjectsGetColumnCommand(G.IApi client) : base(
            name: "projects",
            description: @"Gets information about a project column.")
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
            var response = await _client.Projects.ProjectsGetColumnAsync(
                columnId: columnId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}