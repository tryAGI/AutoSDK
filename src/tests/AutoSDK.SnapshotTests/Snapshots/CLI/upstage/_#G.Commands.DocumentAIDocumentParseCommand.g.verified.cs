//HintName: G.Commands.DocumentAIDocumentParseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DocumentAIDocumentParseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] document,
            string documentname,
            string? model,
            global::G.DocumentParseRequestOcr? ocr,
            bool? coordinates,
            string? outputFormats,
            int? pageStart,
            int? pageEnd,
            string? modelParams,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DocumentParseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> Document { get; } = new(
            name: "document")
        {
            Description = @"The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).",
        };

        private global::System.CommandLine.Argument<string> Documentname { get; } = new(
            name: "documentname")
        {
            Description = @"The document file to parse (PDF, PNG, JPG, JPEG, BMP, TIFF).",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for document parsing.
Default: document-parse",
        };

        private global::System.CommandLine.Option<global::G.DocumentParseRequestOcr?> Ocr { get; } = new(
            name: "ocr")
        {
            Description = @"OCR mode. Set to auto to enable OCR for scanned documents,
or force to always apply OCR.",
        };

        private global::System.CommandLine.Option<bool?> Coordinates { get; } = new(
            name: "coordinates")
        {
            Description = @"Whether to return bounding box coordinates for elements.",
        };

        private global::System.CommandLine.Option<string?> OutputFormats { get; } = new(
            name: "outputFormats")
        {
            Description = @"Comma-separated list of output formats to include.
Options: html, markdown, text",
        };

        private global::System.CommandLine.Option<int?> PageStart { get; } = new(
            name: "pageStart")
        {
            Description = @"Start page number (1-indexed). Use to process a page range.",
        };

        private global::System.CommandLine.Option<int?> PageEnd { get; } = new(
            name: "pageEnd")
        {
            Description = @"End page number (1-indexed, inclusive). Use to process a page range.",
        };

        private global::System.CommandLine.Option<string?> ModelParams { get; } = new(
            name: "modelParams")
        {
            Description = @"JSON string of additional model parameters.",
        };


        public DocumentAIDocumentParseCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "document",
            description: @"Extracts structured content from documents (PDFs, images).
Returns HTML, Markdown, and plain text representations along with
individual elements like paragraphs, tables, figures, and headings.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Document);
            Arguments.Add(Documentname);
            Options.Add(Model);
            Options.Add(Ocr);
            Options.Add(Coordinates);
            Options.Add(OutputFormats);
            Options.Add(PageStart);
            Options.Add(PageEnd);
            Options.Add(ModelParams);

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
            var ocr = parseResult.GetRequiredValue(Ocr);
            var coordinates = parseResult.GetRequiredValue(Coordinates);
            var outputFormats = parseResult.GetRequiredValue(OutputFormats);
            var pageStart = parseResult.GetRequiredValue(PageStart);
            var pageEnd = parseResult.GetRequiredValue(PageEnd);
            var modelParams = parseResult.GetRequiredValue(ModelParams);

            Validate(
                parseResult: parseResult,
                document: document,
                documentname: documentname,
                model: model,
                ocr: ocr,
                coordinates: coordinates,
                outputFormats: outputFormats,
                pageStart: pageStart,
                pageEnd: pageEnd,
                modelParams: modelParams,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DocumentAI.DocumentParseAsync(
                document: document,
                documentname: documentname,
                model: model,
                ocr: ocr,
                coordinates: coordinates,
                outputFormats: outputFormats,
                pageStart: pageStart,
                pageEnd: pageEnd,
                modelParams: modelParams,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}