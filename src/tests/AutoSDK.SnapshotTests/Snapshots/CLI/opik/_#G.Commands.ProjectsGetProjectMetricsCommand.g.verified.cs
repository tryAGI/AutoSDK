//HintName: G.Commands.ProjectsGetProjectMetricsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProjectsGetProjectMetricsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            global::G.ProjectMetricRequestPublicMetricType? metricType,
            global::G.ProjectMetricRequestPublicInterval? interval,
            global::System.DateTime? intervalStart,
            global::System.DateTime? intervalEnd,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? spanFilters,
            global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? traceFilters,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? threadFilters,
            global::G.BreakdownConfigPublic? breakdown,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ProjectMetricResponsePublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ProjectMetricRequestPublicMetricType?> MetricType { get; } = new(
            name: "metricType")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ProjectMetricRequestPublicInterval?> Interval { get; } = new(
            name: "interval")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> IntervalStart { get; } = new(
            name: "intervalStart")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> IntervalEnd { get; } = new(
            name: "intervalEnd")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.SpanFilterPublic>?> SpanFilters { get; } = new(
            name: "spanFilters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TraceFilterPublic>?> TraceFilters { get; } = new(
            name: "traceFilters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>?> ThreadFilters { get; } = new(
            name: "threadFilters")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.BreakdownConfigPublic?> Breakdown { get; } = new(
            name: "breakdown")
        {
            Description = @"",
        };


        public ProjectsGetProjectMetricsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets specified metrics for a project")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(MetricType);
            Options.Add(Interval);
            Options.Add(IntervalStart);
            Options.Add(IntervalEnd);
            Options.Add(SpanFilters);
            Options.Add(TraceFilters);
            Options.Add(ThreadFilters);
            Options.Add(Breakdown);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var metricType = parseResult.GetRequiredValue(MetricType);
            var interval = parseResult.GetRequiredValue(Interval);
            var intervalStart = parseResult.GetRequiredValue(IntervalStart);
            var intervalEnd = parseResult.GetRequiredValue(IntervalEnd);
            var spanFilters = parseResult.GetRequiredValue(SpanFilters);
            var traceFilters = parseResult.GetRequiredValue(TraceFilters);
            var threadFilters = parseResult.GetRequiredValue(ThreadFilters);
            var breakdown = parseResult.GetRequiredValue(Breakdown);

            Validate(
                parseResult: parseResult,
                id: id,
                metricType: metricType,
                interval: interval,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                spanFilters: spanFilters,
                traceFilters: traceFilters,
                threadFilters: threadFilters,
                breakdown: breakdown,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.GetProjectMetricsAsync(
                id: id,
                metricType: metricType,
                interval: interval,
                intervalStart: intervalStart,
                intervalEnd: intervalEnd,
                spanFilters: spanFilters,
                traceFilters: traceFilters,
                threadFilters: threadFilters,
                breakdown: breakdown,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}