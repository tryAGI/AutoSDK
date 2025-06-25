//HintName: G.Commands.CreateVectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVectorStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? fileIds,
            string? name,
            global::G.VectorStoreExpirationAfter? expiresAfter,
            global::G.OneOf<global::G.AutoChunkingStrategyRequestParam, global::G.StaticChunkingStrategyRequestParam>? chunkingStrategy,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VectorStoreObject response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> FileIds { get; } = new(
            name: "fileIds")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.VectorStoreExpirationAfter?> ExpiresAfter { get; } = new(
            name: "expiresAfter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.AutoChunkingStrategyRequestParam, global::G.StaticChunkingStrategyRequestParam>?> ChunkingStrategy { get; } = new(
            name: "chunkingStrategy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateVectorStoreCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Options.Add(FileIds);
            Options.Add(Name);
            Options.Add(ExpiresAfter);
            Options.Add(ChunkingStrategy);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileIds = parseResult.GetRequiredValue(FileIds);
            var name = parseResult.GetRequiredValue(Name);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);
            var chunkingStrategy = parseResult.GetRequiredValue(ChunkingStrategy);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                fileIds: fileIds,
                name: name,
                expiresAfter: expiresAfter,
                chunkingStrategy: chunkingStrategy,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.CreateVectorStoreAsync(
                fileIds: fileIds,
                name: name,
                expiresAfter: expiresAfter,
                chunkingStrategy: chunkingStrategy,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}