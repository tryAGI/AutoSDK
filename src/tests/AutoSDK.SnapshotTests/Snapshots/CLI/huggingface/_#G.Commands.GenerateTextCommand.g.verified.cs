//HintName: G.Commands.GenerateTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelId,
            string? inputs,
            global::G.GenerateTextRequestParameters? parameters,
            global::G.GenerateTextRequestOptions? options,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string?> Inputs { get; } = new(
            name: "inputs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GenerateTextRequestParameters?> Parameters { get; } = new(
            name: "parameters")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GenerateTextRequestOptions?> Options { get; } = new(
            name: "options")
        {
            Description = "",
        };
        public GenerateTextCommand(G.IApi client) : base(
            name: "generate",
            description: @"")
        {
            _client = client;

            Arguments.Add(ModelId);
            Arguments.Add(Inputs);
            Options.Add(Parameters);
            Options.Add(Options);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelId = parseResult.GetRequiredValue(ModelId);
            var inputs = parseResult.GetRequiredValue(Inputs);
            var parameters = parseResult.GetRequiredValue(Parameters);
            var options = parseResult.GetRequiredValue(Options);

            Validate(
                parseResult: parseResult,
                modelId: modelId,
                inputs: inputs,
                parameters: parameters,
                options: options,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.HuggingFace.GenerateTextAsync(
                modelId: modelId,
                inputs: inputs,
                parameters: parameters,
                options: options,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}