//HintName: G.Commands.DistributedClusterTelemetryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DistributedClusterTelemetryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? detailsLevel,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ClusterTelemetryResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> DetailsLevel { get; } = new(
            name: "detailsLevel")
        {
            Description = @"The level of detail to include in the response",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout for this request",
        };


        public DistributedClusterTelemetryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "cluster",
            description: @"Get telemetry data, from the point of view of the cluster. This includes peers info, collections info, shard transfers, and resharding status")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(DetailsLevel);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var detailsLevel = parseResult.GetRequiredValue(DetailsLevel);
            var timeout = parseResult.GetRequiredValue(Timeout);

            Validate(
                parseResult: parseResult,
                detailsLevel: detailsLevel,
                timeout: timeout,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Distributed.ClusterTelemetryAsync(
                detailsLevel: detailsLevel,
                timeout: timeout,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}