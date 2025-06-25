//HintName: G.Commands.MarkdownRenderCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MarkdownRenderCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string text,
            global::G.MarkdownRenderRequestMode? mode,
            string? context,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.MarkdownRenderRequestMode?> Mode { get; } = new(
            name: "mode")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Context { get; } = new(
            name: "context")
        {
            Description = "",
        };
        public MarkdownRenderCommand(G.IApi client) : base(
            name: "markdown",
            description: @"")
        {
            _client = client;

            Arguments.Add(Text);
            Options.Add(Mode);
            Options.Add(Context);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);
            var mode = parseResult.GetRequiredValue(Mode);
            var context = parseResult.GetRequiredValue(Context);

            Validate(
                parseResult: parseResult,
                text: text,
                mode: mode,
                context: context,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Markdown.MarkdownRenderAsync(
                text: text,
                mode: mode,
                context: context,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}