//HintName: G.Commands.RunnersGetJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersGetJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.LocalRunnerJob response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> JobId { get; } = new(
            name: "jobId")
        {
            Description = @"",
        };



        public RunnersGetJobCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a single local runner job's status and results")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JobId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jobId = parseResult.GetRequiredValue(JobId);

            Validate(
                parseResult: parseResult,
                jobId: jobId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Runners.GetJobAsync(
                jobId: jobId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}