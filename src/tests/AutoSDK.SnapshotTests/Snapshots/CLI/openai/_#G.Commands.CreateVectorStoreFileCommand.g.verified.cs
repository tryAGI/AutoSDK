//HintName: G.Commands.CreateVectorStoreFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVectorStoreFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string vectorStoreId,
            string fileId,
            global::G.ChunkingStrategyRequestParam? chunkingStrategy,
            object? attributes,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VectorStoreFileObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VectorStoreId { get; } = new(
            name: "vectorStoreId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChunkingStrategyRequestParam?> ChunkingStrategy { get; } = new(
            name: "chunkingStrategy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Attributes { get; } = new(
            name: "attributes")
        {
            Description = "",
        };
        public CreateVectorStoreFileCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(VectorStoreId);
            Arguments.Add(FileId);
            Options.Add(ChunkingStrategy);
            Options.Add(Attributes);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);
            var fileId = parseResult.GetRequiredValue(FileId);
            var chunkingStrategy = parseResult.GetRequiredValue(ChunkingStrategy);
            var attributes = parseResult.GetRequiredValue(Attributes);

            Validate(
                parseResult: parseResult,
                vectorStoreId: vectorStoreId,
                fileId: fileId,
                chunkingStrategy: chunkingStrategy,
                attributes: attributes,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.CreateVectorStoreFileAsync(
                vectorStoreId: vectorStoreId,
                fileId: fileId,
                chunkingStrategy: chunkingStrategy,
                attributes: attributes,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}