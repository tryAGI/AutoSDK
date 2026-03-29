//HintName: G.Commands.ServiceTelemetryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ServiceTelemetryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? anonymize,
            int? detailsLevel,
            bool? perCollection,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TelemetryResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> Anonymize { get; } = new(
            name: "anonymize")
        {
            Description = @"If true, anonymize result",
        };

        private global::System.CommandLine.Option<int?> DetailsLevel { get; } = new(
            name: "detailsLevel")
        {
            Description = @"Level of details in telemetry data. Minimal level is 0, maximal is infinity",
        };

        private global::System.CommandLine.Option<bool?> PerCollection { get; } = new(
            name: "perCollection")
        {
            Description = @"If true, include per-collection request statistics in the response",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout for this request",
        };


        public ServiceTelemetryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "telemetry",
            description: @"Collect telemetry data including app info, system info, collections info, cluster info, configs and statistics")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Anonymize);
            Options.Add(DetailsLevel);
            Options.Add(PerCollection);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anonymize = parseResult.GetRequiredValue(Anonymize);
            var detailsLevel = parseResult.GetRequiredValue(DetailsLevel);
            var perCollection = parseResult.GetRequiredValue(PerCollection);
            var timeout = parseResult.GetRequiredValue(Timeout);

            Validate(
                parseResult: parseResult,
                anonymize: anonymize,
                detailsLevel: detailsLevel,
                perCollection: perCollection,
                timeout: timeout,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Service.TelemetryAsync(
                anonymize: anonymize,
                detailsLevel: detailsLevel,
                perCollection: perCollection,
                timeout: timeout,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}