//HintName: G.Commands.StoresGetStoreEventHistogramCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresGetStoreEventHistogramCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? bucketSeconds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.StoreEventHistogramResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartTime { get; } = new(
            name: "startTime")
        {
            Description = @"Start time of the histogram",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndTime { get; } = new(
            name: "endTime")
        {
            Description = @"End time of the histogram",
        };

        private global::System.CommandLine.Option<int?> BucketSeconds { get; } = new(
            name: "bucketSeconds")
        {
            Description = @"Number of seconds in each bucket",
        };


        public StoresGetStoreEventHistogramCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get histogram of store events over time.

Args:
    store_identifier: The ID or name of the store.
    histogram_params: Parameters for histogram generation.

Returns:
    StoreEventHistogramResponse: The event histogram.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
            Options.Add(StartTime);
            Options.Add(EndTime);
            Options.Add(BucketSeconds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var startTime = parseResult.GetRequiredValue(StartTime);
            var endTime = parseResult.GetRequiredValue(EndTime);
            var bucketSeconds = parseResult.GetRequiredValue(BucketSeconds);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                startTime: startTime,
                endTime: endTime,
                bucketSeconds: bucketSeconds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.GetStoreEventHistogramAsync(
                storeIdentifier: storeIdentifier,
                startTime: startTime,
                endTime: endTime,
                bucketSeconds: bucketSeconds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}