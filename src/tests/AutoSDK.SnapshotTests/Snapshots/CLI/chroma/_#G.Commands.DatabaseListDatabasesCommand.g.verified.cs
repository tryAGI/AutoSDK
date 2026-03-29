//HintName: G.Commands.DatabaseListDatabasesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatabaseListDatabasesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            int? limit,
            int? offset,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.VecItem> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Tenant { get; } = new(
            name: "tenant")
        {
            Description = @"Tenant UUID",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Limit for pagination",
        };

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"Offset for pagination",
        };


        public DatabaseListDatabasesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Lists all databases for a tenant.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Options.Add(Limit);
            Options.Add(Offset);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                limit: limit,
                offset: offset,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Database.ListDatabasesAsync(
                tenant: tenant,
                limit: limit,
                offset: offset,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}