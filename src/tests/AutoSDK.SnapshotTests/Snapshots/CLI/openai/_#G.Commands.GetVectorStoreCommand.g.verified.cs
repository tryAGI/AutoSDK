//HintName: G.Commands.GetVectorStoreCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVectorStoreCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string vectorStoreId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VectorStoreObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VectorStoreId { get; } = new(
            name: "vectorStoreId")
        {
            Description = "",
        };

        public GetVectorStoreCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(VectorStoreId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var vectorStoreId = parseResult.GetRequiredValue(VectorStoreId);

            Validate(
                parseResult: parseResult,
                vectorStoreId: vectorStoreId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VectorStores.GetVectorStoreAsync(
                vectorStoreId: vectorStoreId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}