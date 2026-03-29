//HintName: G.Commands.DocumentAILayoutAnalysisCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DocumentAILayoutAnalysisCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] document,
            string documentname,
            string? model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.LayoutAnalysisResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> Document { get; } = new(
            name: "document")
        {
            Description = @"The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).",
        };

        private global::System.CommandLine.Argument<string> Documentname { get; } = new(
            name: "documentname")
        {
            Description = @"The document file to analyze (PDF, PNG, JPG, JPEG, BMP, TIFF).",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for layout analysis.
Default: layout-analysis",
        };


        public DocumentAILayoutAnalysisCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "layout",
            description: @"Analyzes the layout structure of documents.
Detects and classifies layout elements such as paragraphs, tables, figures,
headings, lists, captions, headers, footers, equations, and charts.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Document);
            Arguments.Add(Documentname);
            Options.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var document = parseResult.GetRequiredValue(Document);
            var documentname = parseResult.GetRequiredValue(Documentname);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                document: document,
                documentname: documentname,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DocumentAI.LayoutAnalysisAsync(
                document: document,
                documentname: documentname,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}