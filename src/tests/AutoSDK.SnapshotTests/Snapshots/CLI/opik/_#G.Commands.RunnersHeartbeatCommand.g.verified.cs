//HintName: G.Commands.RunnersHeartbeatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersHeartbeatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.LocalRunnerHeartbeatResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> RunnerId { get; } = new(
            name: "runnerId")
        {
            Description = @"",
        };



        public RunnersHeartbeatCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "heartbeat",
            description: @"Refresh local runner heartbeat")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RunnerId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var runnerId = parseResult.GetRequiredValue(RunnerId);

            Validate(
                parseResult: parseResult,
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Runners.HeartbeatAsync(
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}