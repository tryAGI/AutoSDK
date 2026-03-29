//HintName: G.Commands.ProjectsGetProjectKpiCardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetProjectKpiCardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            global::G.KpiCardRequestEntityType entityType,
            string? filters,
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.KpiCardResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.KpiCardRequestEntityType> EntityType { get; } = new(
            name: "entityType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.DateTime> IntervalStart { get; } = new(
            name: "intervalStart")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.DateTime> IntervalEnd { get; } = new(
            name: "intervalEnd")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filters { get; } = new(
            name: "filters")
        {
            Description = @"",
        };


        public ProjectsGetProjectKpiCardsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets KPI card metrics for a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(EntityType);
            Arguments.Add(IntervalStart);
            Arguments.Add(IntervalEnd);
            Options.Add(Filters);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var entityType = parseResult.GetRequiredValue(EntityType);
            var filters = parseResult.GetRequiredValue(Filters);
            var intervalStart = parseResult.GetRequiredValue(IntervalStart);
            var intervalEnd = parseResult.GetRequiredValue(IntervalEnd);

            Validate(
                parseResult: parseResult,
                id: id,
                entityType: entityType,
                filters: filters,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.GetProjectKpiCardsAsync(
                id: id,
                entityType: entityType,
                filters: filters,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}