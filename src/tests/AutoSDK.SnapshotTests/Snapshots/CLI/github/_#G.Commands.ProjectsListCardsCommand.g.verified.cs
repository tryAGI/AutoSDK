//HintName: G.Commands.ProjectsListCardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsListCardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int columnId,
            global::G.ProjectsListCardsArchivedState? archivedState,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ProjectCard> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ColumnId { get; } = new(
            name: "columnId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ProjectsListCardsArchivedState?> ArchivedState { get; } = new(
            name: "archivedState")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public ProjectsListCardsCommand(G.IApi client) : base(
            name: "projects",
            description: @"Lists the project cards in a project.")
        {
            _client = client;

            Arguments.Add(ColumnId);
            Options.Add(ArchivedState);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var columnId = parseResult.GetRequiredValue(ColumnId);
            var archivedState = parseResult.GetRequiredValue(ArchivedState);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                columnId: columnId,
                archivedState: archivedState,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.ProjectsListCardsAsync(
                columnId: columnId,
                archivedState: archivedState,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}