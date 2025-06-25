//HintName: G.Commands.DependencyGraphCreateRepositorySnapshotCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependencyGraphCreateRepositorySnapshotCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int version,
            global::G.SnapshotJob job,
            string sha,
            string @ref,
            global::G.SnapshotDetector detector,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? manifests,
            global::System.DateTime scanned,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DependencyGraphCreateRepositorySnapshotResponse response,
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

        private global::System.CommandLine.Argument<int> Version { get; } = new(
            name: "version")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.SnapshotJob> Job { get; } = new(
            name: "job")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.SnapshotDetector> Detector { get; } = new(
            name: "detector")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.DateTime> Scanned { get; } = new(
            name: "scanned")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::G.Manifest>?> Manifests { get; } = new(
            name: "manifests")
        {
            Description = "",
        };
        public DependencyGraphCreateRepositorySnapshotCommand(G.IApi client) : base(
            name: "dependency",
            description: @"Create a new snapshot of a repository's dependencies.

The authenticated user must have access to the repository.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Version);
            Arguments.Add(Job);
            Arguments.Add(Sha);
            Arguments.Add(Ref);
            Arguments.Add(Detector);
            Arguments.Add(Scanned);
            Options.Add(Metadata);
            Options.Add(Manifests);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var version = parseResult.GetRequiredValue(Version);
            var job = parseResult.GetRequiredValue(Job);
            var sha = parseResult.GetRequiredValue(Sha);
            var @ref = parseResult.GetRequiredValue(Ref);
            var detector = parseResult.GetRequiredValue(Detector);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var manifests = parseResult.GetRequiredValue(Manifests);
            var scanned = parseResult.GetRequiredValue(Scanned);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                version: version,
                job: job,
                sha: sha,
                @ref: @ref,
                detector: detector,
                metadata: metadata,
                manifests: manifests,
                scanned: scanned,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DependencyGraph.DependencyGraphCreateRepositorySnapshotAsync(
                owner: owner,
                repo: repo,
                version: version,
                job: job,
                sha: sha,
                @ref: @ref,
                detector: detector,
                metadata: metadata,
                manifests: manifests,
                scanned: scanned,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}