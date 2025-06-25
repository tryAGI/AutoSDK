//HintName: G.Commands.DetokenizeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DetokenizeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string model,
            global::System.Collections.Generic.IList<int> tokens,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DetokenizeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<int>> Tokens { get; } = new(
            name: "tokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };
        public DetokenizeCommand(G.IApi client) : base(
            name: "detokenize",
            description: @"This endpoint takes tokens using byte-pair encoding and returns their text representation. To learn more about tokenization and byte pair encoding, see the tokens page.")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Tokens);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var model = parseResult.GetRequiredValue(Model);
            var tokens = parseResult.GetRequiredValue(Tokens);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                model: model,
                tokens: tokens,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DetokenizeAsync(
                xClientName: xClientName,
                model: model,
                tokens: tokens,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}