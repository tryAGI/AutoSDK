//HintName: G.Commands.RunnersReportJobResultCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersReportJobResultCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid jobId,
            global::G.LocalRunnerJobResultRequestStatus status,
            global::G.JsonNode? result,
            string? error,
            global::System.Guid? traceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.LocalRunnerJobResultRequestStatus> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonNode?> Result { get; } = new(
            name: "result")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Error { get; } = new(
            name: "error")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };


        public RunnersReportJobResultCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "report",
            description: @"Report local runner job completion or failure")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JobId);
            Arguments.Add(Status);
            Options.Add(Result);
            Options.Add(Error);
            Options.Add(TraceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);
            var status = parseResult.GetRequiredValue(Status);
            var result = parseResult.GetRequiredValue(Result);
            var error = parseResult.GetRequiredValue(Error);
            var traceId = parseResult.GetRequiredValue(TraceId);

            Validate(
                parseResult: parseResult,
                jobId: jobId,
                status: status,
                result: result,
                error: error,
                traceId: traceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Runners.ReportJobResultAsync(
                jobId: jobId,
                status: status,
                result: result,
                error: error,
                traceId: traceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}