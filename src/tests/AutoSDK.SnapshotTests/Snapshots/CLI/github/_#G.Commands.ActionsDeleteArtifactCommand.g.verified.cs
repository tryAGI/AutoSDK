//HintName: G.Commands.ActionsDeleteArtifactCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsDeleteArtifactCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int artifactId,
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

        public ActionsDeleteArtifactCommand(G.IApi client) : base(
            name: "actions",
            description: @"Deletes an artifact for a workflow run.
OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(ArtifactId);

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

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsDeleteArtifactAsync(
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}