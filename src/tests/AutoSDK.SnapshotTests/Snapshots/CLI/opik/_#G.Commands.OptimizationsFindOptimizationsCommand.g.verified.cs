//HintName: G.Commands.OptimizationsFindOptimizationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OptimizationsFindOptimizationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            global::System.Guid? datasetId,
            string? name,
            string? datasetName,
            bool? datasetDeleted,
            global::System.Guid? projectId,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.OptimizationPagePublic response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter optimizations by name (partial match, case insensitive)",
        };

        private global::System.CommandLine.Option<string?> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"Filter optimizations by dataset name (partial match)",
        };

        private global::System.CommandLine.Option<bool?> DatasetDeleted { get; } = new(
            name: "datasetDeleted")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public OptimizationsFindOptimizationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find optimizations")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(DatasetId);
            Options.Add(Name);
            Options.Add(DatasetName);
            Options.Add(DatasetDeleted);
            Options.Add(ProjectId);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var size = parseResult.GetRequiredValue(Size);
            var datasetId = parseResult.GetRequiredValue(DatasetId);
            var name = parseResult.GetRequiredValue(Name);
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var datasetDeleted = parseResult.GetRequiredValue(DatasetDeleted);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                datasetId: datasetId,
                name: name,
                datasetName: datasetName,
                datasetDeleted: datasetDeleted,
                projectId: projectId,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Optimizations.FindOptimizationsAsync(
                page: page,
                size: size,
                datasetId: datasetId,
                name: name,
                datasetName: datasetName,
                datasetDeleted: datasetDeleted,
                projectId: projectId,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}