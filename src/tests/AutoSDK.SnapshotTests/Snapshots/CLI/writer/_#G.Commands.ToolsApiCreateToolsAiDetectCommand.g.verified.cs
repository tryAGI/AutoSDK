//HintName: G.Commands.ToolsApiCreateToolsAiDetectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsAiDetectCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string input,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AiDetectionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"The content to determine if it is AI- or human-generated. Content must have at least 350 characters.",
        };



        public ToolsApiCreateToolsAiDetectCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Detects if content is AI- or human-generated, with a confidence score. Content must have at least 350 characters")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);

            Validate(
                parseResult: parseResult,
                input: input,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsAiDetectAsync(
                input: input,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}