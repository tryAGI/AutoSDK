//HintName: G.Commands.DistributedRemovePeerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedRemovePeerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int peerId,
            int? timeout,
            bool? force,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RemovePeerResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> PeerId { get; } = new(
            name: "peerId")
        {
            Description = @"Id of the peer",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };

        private global::System.CommandLine.Option<bool?> Force { get; } = new(
            name: "force")
        {
            Description = @"If true - removes peer even if it has shards/replicas on it.",
        };


        public DistributedRemovePeerCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "remove",
            description: @"Tries to remove peer from the cluster. Will return an error if peer has shards on it.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(PeerId);
            Options.Add(Timeout);
            Options.Add(Force);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var peerId = parseResult.GetRequiredValue(PeerId);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var force = parseResult.GetRequiredValue(Force);

            Validate(
                parseResult: parseResult,
                peerId: peerId,
                timeout: timeout,
                force: force,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Distributed.RemovePeerAsync(
                peerId: peerId,
                timeout: timeout,
                force: force,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}