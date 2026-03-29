//HintName: G.Commands.ToolsApiCreateToolsPdfParserByFileIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsApiCreateToolsPdfParserByFileIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileId,
            global::G.PdfConversionFormat format,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ParsePdfResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The unique identifier of the file.",
        };

        private global::System.CommandLine.Argument<global::G.PdfConversionFormat> Format { get; } = new(
            name: "format")
        {
            Description = @"The format into which the PDF content should be converted.",
        };



        public ToolsApiCreateToolsPdfParserByFileIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Parse PDF to other formats.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileId);
            Arguments.Add(Format);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileId = parseResult.GetRequiredValue(FileId);
            var format = parseResult.GetRequiredValue(Format);

            Validate(
                parseResult: parseResult,
                fileId: fileId,
                format: format,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ToolsApi.CreateToolsPdfParserByFileIdAsync(
                fileId: fileId,
                format: format,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}