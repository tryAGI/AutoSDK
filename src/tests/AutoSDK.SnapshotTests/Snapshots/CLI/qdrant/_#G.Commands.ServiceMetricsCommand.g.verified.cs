//HintName: G.Commands.ServiceMetricsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ServiceMetricsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool? anonymize,
            bool? perCollection,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<bool?> Anonymize { get; } = new(
            name: "anonymize")
        {
            Description = @"If true, anonymize result",
        };

        private global::System.CommandLine.Option<bool?> PerCollection { get; } = new(
            name: "perCollection")
        {
            Description = @"If true, include per-collection request metrics with a collection label instead of global request metrics",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Timeout for this request",
        };


        public ServiceMetricsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "metrics",
            description: @"Collect metrics data including app info, collections info, cluster info and statistics")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Anonymize);
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
            var perCollection = parseResult.GetRequiredValue(PerCollection);
            var timeout = parseResult.GetRequiredValue(Timeout);

            Validate(
                parseResult: parseResult,
                anonymize: anonymize,
                perCollection: perCollection,
                timeout: timeout,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Service.MetricsAsync(
                anonymize: anonymize,
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