//HintName: G.Commands.DataSourcesGetDataSourceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesGetDataSourceCommand : global::System.CommandLine.Command
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
            Description = @"The ID of the data source to fetch",
        };



        public DataSourcesGetDataSourceCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get a data source by ID.

Args:
    data_source_id: The ID of the data source to fetch.

Returns:
    The data source.")
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
            var response = await _client.DataSources.GetDataSourceAsync(
                dataSourceId: dataSourceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}