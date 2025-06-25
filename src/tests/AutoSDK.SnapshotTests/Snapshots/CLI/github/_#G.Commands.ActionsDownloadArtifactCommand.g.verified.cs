//HintName: G.Commands.ActionsDownloadArtifactCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsDownloadArtifactCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int artifactId,
            string archiveFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ArtifactId { get; } = new(
            name: "artifactId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ArchiveFormat { get; } = new(
            name: "archiveFormat")
        {
            Description = "",
        };

        public ActionsDownloadArtifactCommand(G.IApi client) : base(
            name: "actions",
            description: @"Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for `Location:` in
the response header to find the URL for the download. The `:archive_format` must be `zip`.

OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(ArtifactId);
            Arguments.Add(ArchiveFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var artifactId = parseResult.GetRequiredValue(ArtifactId);
            var archiveFormat = parseResult.GetRequiredValue(ArchiveFormat);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                archiveFormat: archiveFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsDownloadArtifactAsync(
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                archiveFormat: archiveFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}