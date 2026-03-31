//HintName: G.Commands.StoresUpdateStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoresUpdateStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Store response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Guid?>> StoreIdentifier { get; } = new(
            name: "storeIdentifier")
        {
            Description = @"The ID or name of the store",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"New name for the store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"New description",
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


        public StoresUpdateStoreCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update a store by ID or name.

Args:
    store_identifier: The ID or name of the store to update.
    store_update: StoreCreate object containing the name, description, and metadata.

Returns:
    Store: The response containing the updated store details.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StoreIdentifier);
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
            var storeIdentifier = parseResult.GetRequiredValue(StoreIdentifier);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var isPublic = parseResult.GetRequiredValue(IsPublic);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                storeIdentifier: storeIdentifier,
                name: name,
                description: description,
                isPublic: isPublic,
                expiresAfter: expiresAfter,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Stores.UpdateStoreAsync(
                storeIdentifier: storeIdentifier,
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