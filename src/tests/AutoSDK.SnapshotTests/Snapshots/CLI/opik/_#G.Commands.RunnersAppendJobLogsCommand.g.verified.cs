//HintName: G.Commands.RunnersAppendJobLogsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersAppendJobLogsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid jobId,

            global::System.Collections.Generic.IList<global::G.LocalRunnerLogEntry>? request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };



        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
        };


        public RunnersAppendJobLogsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "append",
            description: @"Append log entries for a running local runner job")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JobId);

            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.LocalRunnerLogEntry>>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,
                jobId: jobId,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Runners.AppendJobLogsAsync(
                jobId: jobId,

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}