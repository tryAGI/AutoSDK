//HintName: G.Commands.FileApiGatewayUploadFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileApiGatewayUploadFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string contentDisposition,
            string contentType,
            long contentLength,
            global::System.Guid? graphId,

            byte[] request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ContentDisposition { get; } = new(
            name: "contentDisposition")
        {
            Description = @"The disposition type of the file, typically used to indicate the form-data name. Use `attachment` with the filename parameter to specify the name of the file, for example: `attachment; filename=example.pdf`.",
        };

        private global::System.CommandLine.Argument<string> ContentType { get; } = new(
            name: "contentType")
        {
            Description = @"The [MIME type](https://developer.mozilla.org/en-US/docs/Web/HTTP/MIME_types/Common_types) of the file being uploaded. Supports `txt`, `doc`, `docx`, `ppt`, `pptx`, `jpg`, `png`, `eml`, `html`, `pdf`, `srt`, `csv`, `xls`, `xlsx`, `mp3`, and `mp4` file extensions.",
        };

        private global::System.CommandLine.Argument<long> ContentLength { get; } = new(
            name: "contentLength")
        {
            Description = @"The size of the file in bytes.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> GraphId { get; } = new(
            name: "graphId")
        {
            Description = @"The unique identifier of the Knowledge Graph to associate the uploaded file with.

Note: The response from the upload endpoint does not include the `graphId` field, but the association will be visible when you retrieve the file using the file retrieval endpoint.",
        };


        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
        };


        public FileApiGatewayUploadFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "gateway",
            description: @"Upload a new file to the system. Supports various file formats including PDF, DOC, DOCX, PPT, PPTX, JPG, PNG, EML, HTML, SRT, CSV, XLS, and XLSX.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ContentDisposition);
            Arguments.Add(ContentType);
            Arguments.Add(ContentLength);
            Options.Add(GraphId);

            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentDisposition = parseResult.GetRequiredValue(ContentDisposition);
            var contentType = parseResult.GetRequiredValue(ContentType);
            var contentLength = parseResult.GetRequiredValue(ContentLength);
            var graphId = parseResult.GetRequiredValue(GraphId);

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<byte[]>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,
                contentDisposition: contentDisposition,
                contentType: contentType,
                contentLength: contentLength,
                graphId: graphId,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FileApi.GatewayUploadFileAsync(
                contentDisposition: contentDisposition,
                contentType: contentType,
                contentLength: contentLength,
                graphId: graphId,

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}