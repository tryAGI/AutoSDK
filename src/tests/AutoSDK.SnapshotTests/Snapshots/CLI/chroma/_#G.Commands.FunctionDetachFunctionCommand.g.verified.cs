//HintName: G.Commands.FunctionDetachFunctionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionDetachFunctionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string tenant,
            string database,
            string collectionId,
            string name,
            bool? deleteOutput,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DetachFunctionResponse response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Function name",
        };

        private global::System.CommandLine.Option<bool?> DeleteOutput { get; } = new(
            name: "deleteOutput")
        {
            Description = @"Whether to delete the output collection as well when detaching the function.",
        };


        public FunctionDetachFunctionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "detach",
            description: @"Detaches a function from a collection.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Tenant);
            Arguments.Add(Database);
            Arguments.Add(CollectionId);
            Arguments.Add(Name);
            Options.Add(DeleteOutput);

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
            var name = parseResult.GetRequiredValue(Name);
            var deleteOutput = parseResult.GetRequiredValue(DeleteOutput);

            Validate(
                parseResult: parseResult,
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                name: name,
                deleteOutput: deleteOutput,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Function.DetachFunctionAsync(
                tenant: tenant,
                database: database,
                collectionId: collectionId,
                name: name,
                deleteOutput: deleteOutput,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}