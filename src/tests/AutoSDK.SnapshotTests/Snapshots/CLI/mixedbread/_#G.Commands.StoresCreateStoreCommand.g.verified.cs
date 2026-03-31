//HintName: G.Commands.StoresCreateStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresCreateStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata,
            global::G.StoreConfig2? config,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Store response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Name for the new store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"Description of the store",
        };

        private global::System.CommandLine.Option<bool?> IsPublic { get; } = new(
            name: "isPublic")
        {
            Description = @"Whether the store can be accessed by anyone with valid login credentials",
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

        private global::System.CommandLine.Option<global::G.StoreConfig2?> Config { get; } = new(
            name: "config")
        {
            Description = @"Store-level configuration defaults",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::System.Guid>?> FileIds { get; } = new(
            name: "fileIds")
        {
            Description = @"Optional list of file IDs",
        };


        public StoresCreateStoreCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new vector store.

Args:
    vector_store_create: VectorStoreCreate object containing the name, description, and metadata.

Returns:
    VectorStore: The response containing the created vector store details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Name);
            Options.Add(Description);
            Options.Add(IsPublic);
            Options.Add(ExpiresAfter);
            Options.Add(Metadata);
            Options.Add(Config);
            Options.Add(FileIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var isPublic = parseResult.GetRequiredValue(IsPublic);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var config = parseResult.GetRequiredValue(Config);
            var fileIds = parseResult.GetRequiredValue(FileIds);

            Validate(
                parseResult: parseResult,
                name: name,
                description: description,
                isPublic: isPublic,
                expiresAfter: expiresAfter,
                metadata: metadata,
                config: config,
                fileIds: fileIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.CreateStoreAsync(
                name: name,
                description: description,
                isPublic: isPublic,
                expiresAfter: expiresAfter,
                metadata: metadata,
                config: config,
                fileIds: fileIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}