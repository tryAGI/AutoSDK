//HintName: G.Commands.DeprecatedVectorStoresUpdateVectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoresUpdateVectorStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VectorStore response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> VectorStoreIdentifier { get; } = new(
            name: "vectorStoreIdentifier")
        {
            Description = @"The ID or name of the vector store",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"New name for the store",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"New description",
        };

        private global::System.CommandLine.Option<bool?> IsPublic { get; } = new(
            name: "isPublic")
        {
            Description = @"Whether the vector store can be accessed by anyone with valid login credentials",
        };

        private global::System.CommandLine.Option<global::G.ExpiresAfter?> ExpiresAfter { get; } = new(
            name: "expiresAfter")
        {
            Description = @"Optional expiration policy",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"Optional metadata key-value pairs",
        };


        public DeprecatedVectorStoresUpdateVectorStoreCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"DEPRECATED: Use PUT /stores/{store_identifier} instead")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VectorStoreIdentifier);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(IsPublic);
            Options.Add(ExpiresAfter);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreIdentifier = parseResult.GetRequiredValue(VectorStoreIdentifier);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var isPublic = parseResult.GetRequiredValue(IsPublic);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                vectorStoreIdentifier: vectorStoreIdentifier,
                name: name,
                description: description,
                isPublic: isPublic,
                expiresAfter: expiresAfter,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeprecatedVectorStores.UpdateVectorStoreAsync(
                vectorStoreIdentifier: vectorStoreIdentifier,
                name: name,
                description: description,
                isPublic: isPublic,
                expiresAfter: expiresAfter,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}