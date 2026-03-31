//HintName: G.Commands.EmbeddingsCreateEmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbeddingsCreateEmbeddingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat,
            string? user,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateEmbeddingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>> Input { get; } = new(
            name: "input")
        {
            Description = @"Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model, cannot be an empty string, and any array must be 2048 dimensions or less.",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use.",
        };

        private global::System.CommandLine.Option<global::G.CreateEmbeddingRequestEncodingFormat?> EncodingFormat { get; } = new(
            name: "encodingFormat")
        {
            Description = @"The format to return the embeddings in. Can only be `float` or `base64`.",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"A unique identifier representing your end-user, which can help us monitor and detect abuse.",
        };


        public EmbeddingsCreateEmbeddingCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Arguments.Add(Model);
            Options.Add(EncodingFormat);
            Options.Add(User);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);
            var model = parseResult.GetRequiredValue(Model);
            var encodingFormat = parseResult.GetRequiredValue(EncodingFormat);
            var user = parseResult.GetRequiredValue(User);

            Validate(
                parseResult: parseResult,
                input: input,
                model: model,
                encodingFormat: encodingFormat,
                user: user,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embeddings.CreateEmbeddingAsync(
                input: input,
                model: model,
                encodingFormat: encodingFormat,
                user: user,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}