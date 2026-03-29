//HintName: G.Commands.ProjectsFindExperimentsByProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsFindExperimentsByProjectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid projectId,
            int? page,
            int? size,
            global::System.Guid? datasetId,
            global::System.Guid? optimizationId,
            string? types,
            string? name,
            bool? datasetDeleted,
            string? sorting,
            string? filters,
            string? experimentIds,
            bool? forceSorting,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ExperimentPagePublic response,
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

        private global::System.CommandLine.Option<global::System.Guid?> DatasetId { get; } = new(
            name: "datasetId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> OptimizationId { get; } = new(
            name: "optimizationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Types { get; } = new(
            name: "types")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter experiments by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<bool?> DatasetDeleted { get; } = new(
            name: "datasetDeleted")
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

        private global::System.CommandLine.Option<string?> ExperimentIds { get; } = new(
            name: "experimentIds")
        {
            Description = @"Filter experiments by a list of experiment IDs",
        };

        private global::System.CommandLine.Option<bool?> ForceSorting { get; } = new(
            name: "forceSorting")
        {
            Description = @"Force sorting even when exceeding the endpoint result set limit. May result in slower queries",
        };


        public ProjectsFindExperimentsByProjectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find experiments scoped to a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(DatasetId);
            Options.Add(OptimizationId);
            Options.Add(Types);
            Options.Add(Name);
            Options.Add(DatasetDeleted);
            Options.Add(Sorting);
            Options.Add(Filters);
            Options.Add(ExperimentIds);
            Options.Add(ForceSorting);

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
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var optimizationId = parseResult.GetRequiredValue(OptimizationId);
            var types = parseResult.GetRequiredValue(Types);
            var name = parseResult.GetRequiredValue(Name);
            var datasetDeleted = parseResult.GetRequiredValue(DatasetDeleted);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var filters = parseResult.GetRequiredValue(Filters);
            var experimentIds = parseResult.GetRequiredValue(ExperimentIds);
            var forceSorting = parseResult.GetRequiredValue(ForceSorting);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                page: page,
                size: size,
                datasetId: datasetId,
                optimizationId: optimizationId,
                types: types,
                name: name,
                datasetDeleted: datasetDeleted,
                sorting: sorting,
                filters: filters,
                experimentIds: experimentIds,
                forceSorting: forceSorting,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.FindExperimentsByProjectAsync(
                projectId: projectId,
                page: page,
                size: size,
                datasetId: datasetId,
                optimizationId: optimizationId,
                types: types,
                name: name,
                datasetDeleted: datasetDeleted,
                sorting: sorting,
                filters: filters,
                experimentIds: experimentIds,
                forceSorting: forceSorting,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}