//HintName: G.Commands.WorkspacesCostsSummaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspacesCostsSummaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            bool? startBeforeEnd,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Result response,
            global::System.Threading.CancellationToken cancellationToken);

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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> StartBeforeEnd { get; } = new(
            name: "startBeforeEnd")
        {
            Description = @"",
        };


        public WorkspacesCostsSummaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "costs",
            description: @"Get costs summary")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(IntervalStart);
            Arguments.Add(IntervalEnd);
            Options.Add(ProjectIds);
            Options.Add(StartBeforeEnd);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var intervalStart = parseResult.GetRequiredValue(IntervalStart);
            var intervalEnd = parseResult.GetRequiredValue(IntervalEnd);
            var startBeforeEnd = parseResult.GetRequiredValue(StartBeforeEnd);

            Validate(
                parseResult: parseResult,
                projectIds: projectIds,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                startBeforeEnd: startBeforeEnd,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspaces.CostsSummaryAsync(
                projectIds: projectIds,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                startBeforeEnd: startBeforeEnd,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}