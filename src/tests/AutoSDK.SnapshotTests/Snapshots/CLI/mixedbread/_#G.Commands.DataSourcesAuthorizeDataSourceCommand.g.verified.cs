//HintName: G.Commands.DataSourcesAuthorizeDataSourceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesAuthorizeDataSourceCommand : global::System.CommandLine.Command
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

            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> DataSourceId { get; } = new(
            name: "dataSourceId")
        {
            Description = @"The ID of the data source to authorize",
        };



        public DataSourcesAuthorizeDataSourceCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "authorize",
            description: @"Start OAuth2 authorization flow for a data source.

Initiates the OAuth2 authorization process by redirecting the user
to the external service's authorization page. After authorization,
the user will be redirected back to the oauth2_callback endpoint.

Args:
    data_source_id: The ID of the data source to authorize

Returns:
    Redirect to the OAuth2 provider's authorization page

Raises:
    DataSourceNotFoundError: When data source doesn't exist
    DataSourceAuthTypeNotSupportedError: When OAuth2 is not supported for this data source type")
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
            var response = await _client.DataSources.AuthorizeDataSourceAsync(
                dataSourceId: dataSourceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}