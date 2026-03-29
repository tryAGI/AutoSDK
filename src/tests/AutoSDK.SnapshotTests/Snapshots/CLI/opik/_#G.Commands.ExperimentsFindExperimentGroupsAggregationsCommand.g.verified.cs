//HintName: G.Commands.ExperimentsFindExperimentGroupsAggregationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsFindExperimentGroupsAggregationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? groups,
            string? types,
            string? name,
            global::System.Guid? projectId,
            bool? projectDeleted,
            string? filters,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ExperimentGroupAggregationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Groups { get; } = new(
            name: "groups")
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

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ProjectDeleted { get; } = new(
            name: "projectDeleted")
        {
            Description = @"Filter experiments by deleted projects",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public ExperimentsFindExperimentGroupsAggregationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find experiments grouped by specified fields with aggregation metrics")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Groups);
            Options.Add(Types);
            Options.Add(Name);
            Options.Add(ProjectId);
            Options.Add(ProjectDeleted);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var groups = parseResult.GetRequiredValue(Groups);
            var types = parseResult.GetRequiredValue(Types);
            var name = parseResult.GetRequiredValue(Name);
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var projectDeleted = parseResult.GetRequiredValue(ProjectDeleted);
            var filters = parseResult.GetRequiredValue(Filters);

            Validate(
                parseResult: parseResult,
                groups: groups,
                types: types,
                name: name,
                projectId: projectId,
                projectDeleted: projectDeleted,
                filters: filters,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Experiments.FindExperimentGroupsAggregationsAsync(
                groups: groups,
                types: types,
                name: name,
                projectId: projectId,
                projectDeleted: projectDeleted,
                filters: filters,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}