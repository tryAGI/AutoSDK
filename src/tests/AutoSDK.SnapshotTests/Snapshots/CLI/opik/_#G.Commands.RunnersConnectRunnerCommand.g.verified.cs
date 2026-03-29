//HintName: G.Commands.RunnersConnectRunnerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersConnectRunnerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pairingCode,
            string runnerName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.LocalRunnerConnectResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PairingCode { get; } = new(
            name: "pairingCode")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> RunnerName { get; } = new(
            name: "runnerName")
        {
            Description = @"",
        };



        public RunnersConnectRunnerCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "connect",
            description: @"Exchange a pairing code or API key for local runner credentials")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(PairingCode);
            Arguments.Add(RunnerName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pairingCode = parseResult.GetRequiredValue(PairingCode);
            var runnerName = parseResult.GetRequiredValue(RunnerName);

            Validate(
                parseResult: parseResult,
                pairingCode: pairingCode,
                runnerName: runnerName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Runners.ConnectRunnerAsync(
                pairingCode: pairingCode,
                runnerName: runnerName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}