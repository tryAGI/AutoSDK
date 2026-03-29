//HintName: G.Commands.SystemHeartbeatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SystemHeartbeatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.HeartbeatResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public SystemHeartbeatCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "heartbeat",
            description: @"Returns a nanosecond timestamp of the current time.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.System.HeartbeatAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}