//HintName: G.Commands.CreateEmbeddingV1EmbeddingsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEmbeddingV1EmbeddingsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ModelEmbeddingOutput response,
            global::System.Threading.CancellationToken cancellationToken);


        public CreateEmbeddingV1EmbeddingsPostCommand(G.IApi client) : base(
            name: "create",
            description: @"Create embedding representations of the given input texts.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embeddings.CreateEmbeddingV1EmbeddingsPostAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}