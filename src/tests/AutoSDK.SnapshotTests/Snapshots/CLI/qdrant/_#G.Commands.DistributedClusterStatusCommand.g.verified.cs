//HintName: G.Commands.DistributedClusterStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedClusterStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ClusterStatusResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public DistributedClusterStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "cluster",
            description: @"Get information about the current state and composition of the cluster")
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
            var response = await _client.Distributed.ClusterStatusAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}