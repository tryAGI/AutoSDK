//HintName: G.Commands.DeleteCatalogFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteCatalogFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteCatalogFileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileUid { get; } = new(
            name: "fileUid")
        {
            Description = "",
        };

        public DeleteCatalogFileCommand(G.IApi client) : base(
            name: "delete",
            description: @"Deletes a file.")
        {
            _client = client;

            Arguments.Add(FileUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileUid = parseResult.GetRequiredValue(FileUid);

            Validate(
                parseResult: parseResult,
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.DeleteCatalogFileAsync(
                fileUid: fileUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}