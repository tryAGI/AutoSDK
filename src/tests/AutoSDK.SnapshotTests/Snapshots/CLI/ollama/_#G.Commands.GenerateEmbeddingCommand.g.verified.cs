//HintName: G.Commands.GenerateEmbeddingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateEmbeddingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string prompt,
            global::G.RequestOptions? options,
            int? keepAlive,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateEmbeddingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RequestOptions?> Options { get; } = new(
            name: "options")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> KeepAlive { get; } = new(
            name: "keepAlive")
        {
            Description = "",
        };
        public GenerateEmbeddingCommand(G.IApi client) : base(
            name: "generate",
            description: @"")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Options.Add(Options);
            Options.Add(KeepAlive);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var options = parseResult.GetRequiredValue(Options);
            var keepAlive = parseResult.GetRequiredValue(KeepAlive);

            Validate(
                parseResult: parseResult,
                model: model,
                prompt: prompt,
                options: options,
                keepAlive: keepAlive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Embeddings.GenerateEmbeddingAsync(
                model: model,
                prompt: prompt,
                options: options,
                keepAlive: keepAlive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}