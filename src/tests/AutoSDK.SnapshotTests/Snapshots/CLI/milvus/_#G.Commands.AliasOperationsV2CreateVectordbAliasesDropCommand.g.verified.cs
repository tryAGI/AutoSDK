//HintName: G.Commands.AliasOperationsV2CreateVectordbAliasesDropCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliasOperationsV2CreateVectordbAliasesDropCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string? dbName,
            string collectionName,
            string aliasName1,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionName { get; } = new(
            name: "collectionName")
        {
            Description = @"The name of the collection to which the alias is assigned to.",
        };

        private global::System.CommandLine.Argument<string> AliasName1 { get; } = new(
            name: "aliasName1")
        {
            Description = @"The alias to drop.
When dropping an alias, you do not need to provide the collection name because one alias can only be assigned to exactly one collection. Therefore, the server knows which collection the specified alias belongs to.",
        };

        private global::System.CommandLine.Option<int?> RequestTimeout { get; } = new(
            name: "requestTimeout")
        {
            Description = @"The timeout duration for this operation in seconds. Setting this to None indicates that this operation timeouts when any response arrives or any error occurs.",
        };

        private global::System.CommandLine.Option<string?> Authorization { get; } = new(
            name: "authorization")
        {
            Description = @"The authentication token.",
        };

        private global::System.CommandLine.Option<string?> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database to which the collection belongs.",
        };


        public AliasOperationsV2CreateVectordbAliasesDropCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation drops a specified alias.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CollectionName);
            Arguments.Add(AliasName1);
            Options.Add(RequestTimeout);
            Options.Add(Authorization);
            Options.Add(DbName);

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
            var aliasName1 = parseResult.GetRequiredValue(AliasName1);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                aliasName1: aliasName1,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.AliasOperationsV2.CreateVectordbAliasesDropAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                collectionName: collectionName,
                aliasName1: aliasName1,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}