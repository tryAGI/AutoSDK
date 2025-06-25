//HintName: G.Commands.CompleteUploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompleteUploadCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string uploadId,
            global::System.Collections.Generic.IList<string> partIds,
            string? md5,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> PartIds { get; } = new(
            name: "partIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Md5 { get; } = new(
            name: "md5")
        {
            Description = "",
        };
        public CompleteUploadCommand(G.IOpenAiClient client) : base(
            name: "complete",
            description: @"")
        {
            _client = client;

            Arguments.Add(UploadId);
            Arguments.Add(PartIds);
            Options.Add(Md5);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uploadId = parseResult.GetRequiredValue(UploadId);
            var partIds = parseResult.GetRequiredValue(PartIds);
            var md5 = parseResult.GetRequiredValue(Md5);

            Validate(
                parseResult: parseResult,
                uploadId: uploadId,
                partIds: partIds,
                md5: md5,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Uploads.CompleteUploadAsync(
                uploadId: uploadId,
                partIds: partIds,
                md5: md5,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}