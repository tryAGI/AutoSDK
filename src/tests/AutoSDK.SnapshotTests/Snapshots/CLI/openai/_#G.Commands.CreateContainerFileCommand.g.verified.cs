//HintName: G.Commands.CreateContainerFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateContainerFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string containerId,
            string? fileId,
            byte[]? file,
            string? filename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ContainerFileResource response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ContainerId { get; } = new(
            name: "containerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> FileId { get; } = new(
            name: "fileId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };
        public CreateContainerFileCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"Creates a container file.
")
        {
            _client = client;

            Arguments.Add(ContainerId);
            Options.Add(FileId);
            Options.Add(File);
            Options.Add(Filename);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var containerId = parseResult.GetRequiredValue(ContainerId);
            var fileId = parseResult.GetRequiredValue(FileId);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);

            Validate(
                parseResult: parseResult,
                containerId: containerId,
                fileId: fileId,
                file: file,
                filename: filename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateContainerFileAsync(
                containerId: containerId,
                fileId: fileId,
                file: file,
                filename: filename,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}