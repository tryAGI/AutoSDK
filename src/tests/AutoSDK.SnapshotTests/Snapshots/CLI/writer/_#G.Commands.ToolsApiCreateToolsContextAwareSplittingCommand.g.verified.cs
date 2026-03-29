//HintName: G.Commands.ToolsApiCreateToolsContextAwareSplittingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsContextAwareSplittingCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string text,
            global::G.SplittingStrategy strategy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ContextAwareSplittingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The text to split into chunks.",
        };

        private global::System.CommandLine.Argument<global::G.SplittingStrategy> Strategy { get; } = new(
            name: "strategy")
        {
            Description = @"",
        };



        public ToolsApiCreateToolsContextAwareSplittingCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Splits a long block of text (maximum 4000 words) into smaller chunks while preserving the semantic meaning of the text and context between the chunks.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);
            Arguments.Add(Strategy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);
            var strategy = parseResult.GetRequiredValue(Strategy);

            Validate(
                parseResult: parseResult,
                text: text,
                strategy: strategy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsContextAwareSplittingAsync(
                text: text,
                strategy: strategy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}