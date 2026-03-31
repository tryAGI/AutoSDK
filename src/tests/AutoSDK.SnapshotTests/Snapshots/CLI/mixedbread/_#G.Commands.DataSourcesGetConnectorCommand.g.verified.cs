//HintName: G.Commands.DataSourcesGetConnectorCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesGetConnectorCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid dataSourceId,
            global::System.Guid connectorId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DataSourceConnector response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DataSourceId { get; } = new(
            name: "dataSourceId")
        {
            Description = @"The ID of the data source to get a connector for",
        };

        private global::System.CommandLine.Argument<global::System.Guid> ConnectorId { get; } = new(
            name: "connectorId")
        {
            Description = @"The ID of the connector to get",
        };



        public DataSourcesGetConnectorCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a connector by ID.

Args:
    data_source_id: The ID of the data source to get a connector for.
    connector_id: The ID of the connector to get.

Returns:
    The connector.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DataSourceId);
            Arguments.Add(ConnectorId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dataSourceId = parseResult.GetRequiredValue(DataSourceId);
            var connectorId = parseResult.GetRequiredValue(ConnectorId);

            Validate(
                parseResult: parseResult,
                dataSourceId: dataSourceId,
                connectorId: connectorId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DataSources.GetConnectorAsync(
                dataSourceId: dataSourceId,
                connectorId: connectorId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}