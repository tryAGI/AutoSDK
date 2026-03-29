//HintName: G.Commands.ToolsApiCreateToolsComprehendMedicalCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsComprehendMedicalCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string content,
            global::G.ComprehendMedicalType responseType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MedicalComprehendResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = @"The text to analyze.",
        };

        private global::System.CommandLine.Argument<global::G.ComprehendMedicalType> ResponseType { get; } = new(
            name: "responseType")
        {
            Description = @"",
        };



        public ToolsApiCreateToolsComprehendMedicalCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Analyze unstructured medical text to extract entities labeled with standardized medical codes and confidence scores.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Content);
            Arguments.Add(ResponseType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var content = parseResult.GetRequiredValue(Content);
            var responseType = parseResult.GetRequiredValue(ResponseType);

            Validate(
                parseResult: parseResult,
                content: content,
                responseType: responseType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsComprehendMedicalAsync(
                content: content,
                responseType: responseType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}