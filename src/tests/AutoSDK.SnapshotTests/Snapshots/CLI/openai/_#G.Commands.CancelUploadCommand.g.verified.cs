//HintName: G.Commands.CancelUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string uploadId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Upload response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UploadId { get; } = new(
            name: "uploadId")
        {
            Description = "",
        };

        public CancelUploadCommand(G.IOpenAiClient client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(UploadId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uploadId = parseResult.GetRequiredValue(UploadId);

            Validate(
                parseResult: parseResult,
                uploadId: uploadId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Uploads.CancelUploadAsync(
                uploadId: uploadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}