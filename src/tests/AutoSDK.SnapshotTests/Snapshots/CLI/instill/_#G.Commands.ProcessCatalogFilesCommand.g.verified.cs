//HintName: G.Commands.ProcessCatalogFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ProcessCatalogFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? instillRequesterUid,
            global::System.Collections.Generic.IList<string> fileUids,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProcessCatalogFilesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> FileUids { get; } = new(
            name: "fileUids")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"",
        };
        public ProcessCatalogFilesCommand(G.IApi client) : base(
            name: "process",
            description: @"Processes catalog files.")
        {
            _client = client;

            Arguments.Add(FileUids);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);
            var fileUids = parseResult.GetRequiredValue(FileUids);

            Validate(
                parseResult: parseResult,
                instillRequesterUid: instillRequesterUid,
                fileUids: fileUids,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.ProcessCatalogFilesAsync(
                instillRequesterUid: instillRequesterUid,
                fileUids: fileUids,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}