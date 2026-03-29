//HintName: G.Commands.RunnersGetJobLogsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersGetJobLogsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid jobId,
            int? offset,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.LocalRunnerLogEntry> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"",
        };


        public RunnersGetJobLogsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get log entries for a local runner job")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JobId);
            Options.Add(Offset);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);
            var offset = parseResult.GetRequiredValue(Offset);

            Validate(
                parseResult: parseResult,
                jobId: jobId,
                offset: offset,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Runners.GetJobLogsAsync(
                jobId: jobId,
                offset: offset,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}