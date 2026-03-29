//HintName: G.Commands.CollectionCreateCollectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionCreateCollectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            global::G.OneOf<object, global::G.CollectionConfiguration>? configuration,
            bool? getOrCreate,
            global::G.OneOf<object, global::G.HashMap>? metadata,
            string name,
            global::G.OneOf<object, global::G.Schema3>? schema,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Collection response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OneOf<object, global::G.CollectionConfiguration>?> Configuration { get; } = new(
            name: "configuration")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> GetOrCreate { get; } = new(
            name: "getOrCreate")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OneOf<object, global::G.HashMap>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OneOf<object, global::G.Schema3>?> Schema { get; } = new(
            name: "schema")
        {
            Description = @"",
        };


        public CollectionCreateCollectionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a new collection in a database.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(Name);
            Options.Add(Configuration);
            Options.Add(GetOrCreate);
            Options.Add(Metadata);
            Options.Add(Schema);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var database = parseResult.GetRequiredValue(Database);
            var configuration = parseResult.GetRequiredValue(Configuration);
            var getOrCreate = parseResult.GetRequiredValue(GetOrCreate);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var name = parseResult.GetRequiredValue(Name);
            var schema = parseResult.GetRequiredValue(Schema);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                configuration: configuration,
                getOrCreate: getOrCreate,
                metadata: metadata,
                name: name,
                schema: schema,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Collection.CreateCollectionAsync(
                tenant: tenant,
                database: database,
                configuration: configuration,
                getOrCreate: getOrCreate,
                metadata: metadata,
                name: name,
                schema: schema,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}