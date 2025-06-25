//HintName: G.Commands.CreateUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string filename,
            global::G.CreateUploadRequestPurpose purpose,
            int bytes,
            string mimeType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Upload response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CreateUploadRequestPurpose> Purpose { get; } = new(
            name: "purpose")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> Bytes { get; } = new(
            name: "bytes")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> MimeType { get; } = new(
            name: "mimeType")
        {
            Description = "",
        };

        public CreateUploadCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Filename);
            Arguments.Add(Purpose);
            Arguments.Add(Bytes);
            Arguments.Add(MimeType);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filename = parseResult.GetRequiredValue(Filename);
            var purpose = parseResult.GetRequiredValue(Purpose);
            var bytes = parseResult.GetRequiredValue(Bytes);
            var mimeType = parseResult.GetRequiredValue(MimeType);

            Validate(
                parseResult: parseResult,
                filename: filename,
                purpose: purpose,
                bytes: bytes,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Uploads.CreateUploadAsync(
                filename: filename,
                purpose: purpose,
                bytes: bytes,
                mimeType: mimeType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}