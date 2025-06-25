//HintName: G.Commands.RetrieveContainerFileContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetrieveContainerFileContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string containerId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ContainerId { get; } = new(
            name: "containerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = "",
        };

        public RetrieveContainerFileContentCommand(G.IOpenAiClient client) : base(
            name: "retrieve",
            description: @"Retrieves a container file content.")
        {
            _client = client;

            Arguments.Add(ContainerId);
            Arguments.Add(FileId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var containerId = parseResult.GetRequiredValue(ContainerId);
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                containerId: containerId,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.RetrieveContainerFileContentAsync(
                containerId: containerId,
                fileId: fileId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}