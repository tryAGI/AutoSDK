//HintName: G.Commands.AliasOperationsV2CreateVectordbAliasesDescribeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliasOperationsV2CreateVectordbAliasesDescribeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? requestTimeout,
            string? authorization,
            string dbName,
            string aliasName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateVectordbAliasesDescribeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DbName { get; } = new(
            name: "dbName")
        {
            Description = @"The name of the database to which the collection belongs.",
        };

        private global::System.CommandLine.Argument<string> AliasName { get; } = new(
            name: "aliasName")
        {
            Description = @"The name of the alias whose details are to be listed.",
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


        public AliasOperationsV2CreateVectordbAliasesDescribeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"This operation describes the details of a specific alias.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DbName);
            Arguments.Add(AliasName);
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
            var aliasName = parseResult.GetRequiredValue(AliasName);

            Validate(
                parseResult: parseResult,
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                aliasName: aliasName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AliasOperationsV2.CreateVectordbAliasesDescribeAsync(
                requestTimeout: requestTimeout,
                authorization: authorization,
                dbName: dbName,
                aliasName: aliasName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}