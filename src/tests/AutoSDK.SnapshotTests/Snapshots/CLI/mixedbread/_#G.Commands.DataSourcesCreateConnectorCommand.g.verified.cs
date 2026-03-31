//HintName: G.Commands.DataSourcesCreateConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesCreateConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid dataSourceId,
            string storeId,
            string? name,
            bool? triggerSync,
            object? metadata,
            global::G.AnyOf<int?, string, object>? pollingInterval,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DataSourceConnector response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DataSourceId { get; } = new(
            name: "dataSourceId")
        {
            Description = @"The ID of the data source to create a connector for",
        };

        private global::System.CommandLine.Argument<string> StoreId { get; } = new(
            name: "storeId")
        {
            Description = @"The ID of the store",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the connector",
        };

        private global::System.CommandLine.Option<bool?> TriggerSync { get; } = new(
            name: "triggerSync")
        {
            Description = @"Whether the connector should be synced after creation",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"The metadata of the connector",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<int?, string, object>?> PollingInterval { get; } = new(
            name: "pollingInterval")
        {
            Description = @"Polling interval for the connector. Defaults to 30 minutes if not specified. Can be provided as:
- int: Number of seconds (e.g., 1800 for 30 minutes)
- str: Duration string (e.g., '30m', '1h', '2d') or ISO 8601 format (e.g., 'PT30M', 'P1D')
Valid range: 15 seconds to 30 days",
        };


        public DataSourcesCreateConnectorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new connector.

Args:
    data_source_id: The ID of the data source to create a connector for.
    params: The connector to create.

Returns:
    The created connector.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DataSourceId);
            Arguments.Add(StoreId);
            Options.Add(Name);
            Options.Add(TriggerSync);
            Options.Add(Metadata);
            Options.Add(PollingInterval);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dataSourceId = parseResult.GetRequiredValue(DataSourceId);
            var storeId = parseResult.GetRequiredValue(StoreId);
            var name = parseResult.GetRequiredValue(Name);
            var triggerSync = parseResult.GetRequiredValue(TriggerSync);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var pollingInterval = parseResult.GetRequiredValue(PollingInterval);

            Validate(
                parseResult: parseResult,
                dataSourceId: dataSourceId,
                storeId: storeId,
                name: name,
                triggerSync: triggerSync,
                metadata: metadata,
                pollingInterval: pollingInterval,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DataSources.CreateConnectorAsync(
                dataSourceId: dataSourceId,
                storeId: storeId,
                name: name,
                triggerSync: triggerSync,
                metadata: metadata,
                pollingInterval: pollingInterval,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}