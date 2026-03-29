//HintName: G.Commands.ProjectsFindOptimizationsByProjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsFindOptimizationsByProjectCommand : global::System.CommandLine.Command
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
            string? datasetName,
            string? name,
            bool? datasetDeleted,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.OptimizationPagePublic response,
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

        private global::System.CommandLine.Option<string?> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter optimizations by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<bool?> DatasetDeleted { get; } = new(
            name: "datasetDeleted")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public ProjectsFindOptimizationsByProjectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find optimizations scoped to a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ProjectId);
            Options.Add(Page);
            Options.Add(Size);
            Options.Add(DatasetId);
            Options.Add(DatasetName);
            Options.Add(Name);
            Options.Add(DatasetDeleted);
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
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var name = parseResult.GetRequiredValue(Name);
            var datasetDeleted = parseResult.GetRequiredValue(DatasetDeleted);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                page: page,
                size: size,
                datasetId: datasetId,
                datasetName: datasetName,
                name: name,
                datasetDeleted: datasetDeleted,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.FindOptimizationsByProjectAsync(
                projectId: projectId,
                page: page,
                size: size,
                datasetId: datasetId,
                datasetName: datasetName,
                name: name,
                datasetDeleted: datasetDeleted,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}