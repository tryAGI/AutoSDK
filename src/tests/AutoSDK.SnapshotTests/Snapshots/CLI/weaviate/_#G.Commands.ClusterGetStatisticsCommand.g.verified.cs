//HintName: G.Commands.ClusterGetStatisticsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClusterGetStatisticsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ClusterStatisticsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public ClusterGetStatisticsCommand(G.IApi client) : base(
            name: "cluster",
            description: @"Returns Raft cluster statistics of Weaviate DB.")
        {
            _client = client;


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
            var response = await _client.Cluster.ClusterGetStatisticsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}