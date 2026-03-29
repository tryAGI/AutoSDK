//HintName: G.Commands.FunctionAttachFunctionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionAttachFunctionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            string functionId,
            string name,
            string outputCollection,
            object? @params,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AttachFunctionResponse response,
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

        private global::System.CommandLine.Argument<string> CollectionId { get; } = new(
            name: "collectionId")
        {
            Description = @"Collection UUID",
        };

        private global::System.CommandLine.Argument<string> FunctionId { get; } = new(
            name: "functionId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> OutputCollection { get; } = new(
            name: "outputCollection")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> Params { get; } = new(
            name: "@params")
        {
            Description = @"",
        };


        public FunctionAttachFunctionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "attach",
            description: @"Attaches a function to a collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);
            Arguments.Add(FunctionId);
            Arguments.Add(Name);
            Arguments.Add(OutputCollection);
            Options.Add(Params);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tenant = parseResult.GetRequiredValue(Tenant);
            var database = parseResult.GetRequiredValue(Database);
            var collectionId = parseResult.GetRequiredValue(CollectionId);
            var functionId = parseResult.GetRequiredValue(FunctionId);
            var name = parseResult.GetRequiredValue(Name);
            var outputCollection = parseResult.GetRequiredValue(OutputCollection);
            var @params = parseResult.GetRequiredValue(Params);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                functionId: functionId,
                name: name,
                outputCollection: outputCollection,
                @params: @params,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Function.AttachFunctionAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                functionId: functionId,
                name: name,
                outputCollection: outputCollection,
                @params: @params,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}