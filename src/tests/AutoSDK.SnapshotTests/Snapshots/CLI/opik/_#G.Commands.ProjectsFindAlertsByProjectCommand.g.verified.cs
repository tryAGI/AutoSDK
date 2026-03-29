//HintName: G.Commands.ProjectsFindAlertsByProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsFindAlertsByProjectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid projectId,
            int? page,
            int? size,
            string? sorting,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AlertPagePublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Size { get; } = new(
            name: "size")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Sorting { get; } = new(
            name: "sorting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public ProjectsFindAlertsByProjectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find alerts scoped to a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(Sorting);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                page: page,
                size: size,
                sorting: sorting,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.FindAlertsByProjectAsync(
                projectId: projectId,
                page: page,
                size: size,
                sorting: sorting,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}