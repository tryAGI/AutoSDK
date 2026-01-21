//HintName: G.Commands.TokenizeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TokenizeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string text,
            string model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TokenizeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The string to be tokenized, the minimum text length is 1 character, and the maximum text length is 65536 characters.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The input will be tokenized by the tokenizer that is used by this model.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public TokenizeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "tokenize",
            description: @"This endpoint splits input text into smaller units called tokens using byte-pair encoding (BPE). To learn more about tokenization and byte pair encoding, see the tokens page.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);
            Arguments.Add(Model);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var text = parseResult.GetRequiredValue(Text);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                text: text,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TokenizeAsync(
                xClientName: xClientName,
                text: text,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}