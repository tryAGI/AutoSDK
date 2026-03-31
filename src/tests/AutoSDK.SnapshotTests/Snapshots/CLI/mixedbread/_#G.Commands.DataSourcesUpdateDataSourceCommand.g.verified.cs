//HintName: G.Commands.DataSourcesUpdateDataSourceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesUpdateDataSourceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid dataSourceId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DataSource response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DataSourceId { get; } = new(
            name: "dataSourceId")
        {
            Description = @"The ID of the data source to update",
        };



        public DataSourcesUpdateDataSourceCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a data source.

Args:
    data_source_id: The ID of the data source to update.
    params: The data source to update.

Returns:
    The updated data source.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DataSourceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dataSourceId = parseResult.GetRequiredValue(DataSourceId);

            Validate(
                parseResult: parseResult,
                dataSourceId: dataSourceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DataSources.UpdateDataSourceAsync(
                dataSourceId: dataSourceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}