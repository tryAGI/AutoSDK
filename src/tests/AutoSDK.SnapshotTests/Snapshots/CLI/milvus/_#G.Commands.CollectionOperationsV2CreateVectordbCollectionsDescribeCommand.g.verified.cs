//HintName: G.Commands.CollectionOperationsV2CreateVectordbCollectionsDescribeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionOperationsV2CreateVectordbCollectionsDescribeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string dbName,
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateVectordbCollectionsDescribeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database.",
        };

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the collection to describe.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation. Setting this to None indicates that this operation times out when any response returns or an error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };


        public CollectionOperationsV2CreateVectordbCollectionsDescribeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Describes the details of a collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DbName);
            Arguments.Add(CollectionName);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var requestTimeout = parseResult.GetRequiredValue(RequestTimeout);
            var authorization = parseResult.GetRequiredValue(Authorization);
            var dbName = parseResult.GetRequiredValue(DbName);
            var collectionName = parseResult.GetRequiredValue(CollectionName);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CollectionOperationsV2.CreateVectordbCollectionsDescribeAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}