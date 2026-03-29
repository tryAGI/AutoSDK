//HintName: G.Commands.DatasetsFindDatasetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsFindDatasetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? size,
            bool? withExperimentsOnly,
            bool? withOptimizationsOnly,
            global::System.Guid? promptId,
            global::System.Guid? projectId,
            string? name,
            string? sorting,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetPagePublic response,
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

        private global::System.CommandLine.Option<bool?> WithExperimentsOnly { get; } = new(
            name: "withExperimentsOnly")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> WithOptimizationsOnly { get; } = new(
            name: "withOptimizationsOnly")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> PromptId { get; } = new(
            name: "promptId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Filter datasets by name (partial match, case insensitive)",
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


        public DatasetsFindDatasetsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find datasets")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Page);
            Options.Add(Size);
            Options.Add(WithExperimentsOnly);
            Options.Add(WithOptimizationsOnly);
            Options.Add(PromptId);
            Options.Add(ProjectId);
            Options.Add(Name);
            Options.Add(Sorting);
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
            var withExperimentsOnly = parseResult.GetRequiredValue(WithExperimentsOnly);
            var withOptimizationsOnly = parseResult.GetRequiredValue(WithOptimizationsOnly);
            var promptId = parseResult.GetRequiredValue(PromptId);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var name = parseResult.GetRequiredValue(Name);
            var sorting = parseResult.GetRequiredValue(Sorting);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                page: page,
                size: size,
                withExperimentsOnly: withExperimentsOnly,
                withOptimizationsOnly: withOptimizationsOnly,
                promptId: promptId,
                projectId: projectId,
                name: name,
                sorting: sorting,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.FindDatasetsAsync(
                page: page,
                size: size,
                withExperimentsOnly: withExperimentsOnly,
                withOptimizationsOnly: withOptimizationsOnly,
                promptId: promptId,
                projectId: projectId,
                name: name,
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