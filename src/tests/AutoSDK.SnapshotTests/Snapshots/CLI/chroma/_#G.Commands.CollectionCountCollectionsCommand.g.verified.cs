//HintName: G.Commands.CollectionCountCollectionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionCountCollectionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            int response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Tenant { get; } = new(
            name: "tenant")
        {
            Description = @"Tenant UUID",
        };

        private global::System.CommandLine.Argument<string> Database { get; } = new(
            name: "database")
        {
            Description = @"Database name",
        };



        public CollectionCountCollectionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "count",
            description: @"Returns the total number of collections in a database.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var database = parseResult.GetRequiredValue(Database);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collection.CountCollectionsAsync(
                tenant: tenant,
                database: database,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}