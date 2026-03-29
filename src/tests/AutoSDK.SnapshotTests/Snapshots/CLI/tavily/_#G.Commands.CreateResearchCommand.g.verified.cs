//HintName: G.Commands.CreateResearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateResearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string input,
            global::G.CreateResearchRequestModel? model,
            bool? stream,
            global::G.CreateResearchRequestOutputSchema? outputSchema,
            global::G.CreateResearchRequestCitationFormat? citationFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateResearchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"The research task or question to investigate.",
        };

        private global::System.CommandLine.Option<global::G.CreateResearchRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model used by the research agent. ""mini"" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. ""pro"" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.",
        };

        private global::System.CommandLine.Option<global::G.CreateResearchRequestOutputSchema?> OutputSchema { get; } = new(
            name: "outputSchema")
        {
            Description = @"A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.",
        };

        private global::System.CommandLine.Option<global::G.CreateResearchRequestCitationFormat?> CitationFormat { get; } = new(
            name: "citationFormat")
        {
            Description = @"The format for citations in the research report.",
        };


        public CreateResearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Options.Add(Model);
            Options.Add(Stream);
            Options.Add(OutputSchema);
            Options.Add(CitationFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);
            var model = parseResult.GetRequiredValue(Model);
            var stream = parseResult.GetRequiredValue(Stream);
            var outputSchema = parseResult.GetRequiredValue(OutputSchema);
            var citationFormat = parseResult.GetRequiredValue(CitationFormat);

            Validate(
                parseResult: parseResult,
                input: input,
                model: model,
                stream: stream,
                outputSchema: outputSchema,
                citationFormat: citationFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateResearchAsync(
                input: input,
                model: model,
                stream: stream,
                outputSchema: outputSchema,
                citationFormat: citationFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}