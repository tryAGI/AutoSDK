//HintName: G.Commands.CreateEmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEmbeddingCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> input,
            global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat,
            int? dimensions,
            string? user,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateEmbeddingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>> Input { get; } = new(
            name: "input")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateEmbeddingRequestEncodingFormat?> EncodingFormat { get; } = new(
            name: "encodingFormat")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Dimensions { get; } = new(
            name: "dimensions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = "",
        };
        public CreateEmbeddingCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Input);
            Arguments.Add(Model);
            Options.Add(EncodingFormat);
            Options.Add(Dimensions);
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
            var dimensions = parseResult.GetRequiredValue(Dimensions);
            var user = parseResult.GetRequiredValue(User);

            Validate(
                parseResult: parseResult,
                input: input,
                model: model,
                encodingFormat: encodingFormat,
                dimensions: dimensions,
                user: user,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embeddings.CreateEmbeddingAsync(
                input: input,
                model: model,
                encodingFormat: encodingFormat,
                dimensions: dimensions,
                user: user,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}