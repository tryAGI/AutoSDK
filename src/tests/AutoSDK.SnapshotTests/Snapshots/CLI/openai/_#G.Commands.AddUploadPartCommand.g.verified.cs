//HintName: G.Commands.AddUploadPartCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AddUploadPartCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string uploadId,
            byte[] data,
            string dataname,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UploadPart response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UploadId { get; } = new(
            name: "uploadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<byte[]> Data { get; } = new(
            name: "data")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Dataname { get; } = new(
            name: "dataname")
        {
            Description = "",
        };

        public AddUploadPartCommand(G.IOpenAiClient client) : base(
            name: "add",
            description: @"")
        {
            _client = client;

            Arguments.Add(UploadId);
            Arguments.Add(Data);
            Arguments.Add(Dataname);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var uploadId = parseResult.GetRequiredValue(UploadId);
            var data = parseResult.GetRequiredValue(Data);
            var dataname = parseResult.GetRequiredValue(Dataname);

            Validate(
                parseResult: parseResult,
                uploadId: uploadId,
                data: data,
                dataname: dataname,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Uploads.AddUploadPartAsync(
                uploadId: uploadId,
                data: data,
                dataname: dataname,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}