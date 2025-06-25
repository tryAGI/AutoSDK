//HintName: G.Commands.ReposCreatePagesDeploymentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreatePagesDeploymentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            double? artifactId,
            string? artifactUrl,
            string? environment,
            string pagesBuildVersion,
            string oidcToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PageDeployment response,
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

        private global::System.CommandLine.Argument<string> PagesBuildVersion { get; } = new(
            name: "pagesBuildVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> OidcToken { get; } = new(
            name: "oidcToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> ArtifactId { get; } = new(
            name: "artifactId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ArtifactUrl { get; } = new(
            name: "artifactUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Environment { get; } = new(
            name: "environment")
        {
            Description = "",
        };
        public ReposCreatePagesDeploymentCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create a GitHub Pages deployment for a repository.

The authenticated user must have write permission to the repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PagesBuildVersion);
            Arguments.Add(OidcToken);
            Options.Add(ArtifactId);
            Options.Add(ArtifactUrl);
            Options.Add(Environment);

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
            var artifactUrl = parseResult.GetRequiredValue(ArtifactUrl);
            var environment = parseResult.GetRequiredValue(Environment);
            var pagesBuildVersion = parseResult.GetRequiredValue(PagesBuildVersion);
            var oidcToken = parseResult.GetRequiredValue(OidcToken);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                artifactUrl: artifactUrl,
                environment: environment,
                pagesBuildVersion: pagesBuildVersion,
                oidcToken: oidcToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreatePagesDeploymentAsync(
                owner: owner,
                repo: repo,
                artifactId: artifactId,
                artifactUrl: artifactUrl,
                environment: environment,
                pagesBuildVersion: pagesBuildVersion,
                oidcToken: oidcToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}