//HintName: G.Commands.ToolsApiCreateToolsTextToGraphCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsTextToGraphCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TextToGraphResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The text to convert into a graph structure. Maximum of 35,000 words.",
        };



        public ToolsApiCreateToolsTextToGraphCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Performs name entity recognition on the supplied text accepting a maximum of 35000 words.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsTextToGraphAsync(
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}