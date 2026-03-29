//HintName: G.Commands.FileApiGatewayGetFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileApiGatewayGetFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The unique identifier of the file.",
        };



        public FileApiGatewayGetFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "gateway",
            description: @"Retrieve detailed information about a specific file, including its metadata, status, and associated graphs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FileApi.GatewayGetFileAsync(
                fileId: fileId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}