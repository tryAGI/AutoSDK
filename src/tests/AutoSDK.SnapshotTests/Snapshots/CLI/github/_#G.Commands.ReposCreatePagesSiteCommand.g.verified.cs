//HintName: G.Commands.ReposCreatePagesSiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreatePagesSiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.ReposCreatePagesSiteRequestBuildType? buildType,
            global::G.ReposCreatePagesSiteRequestSource? source,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Page response,
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

        private global::System.CommandLine.Option<global::G.ReposCreatePagesSiteRequestBuildType?> BuildType { get; } = new(
            name: "buildType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreatePagesSiteRequestSource?> Source { get; } = new(
            name: "source")
        {
            Description = "",
        };
        public ReposCreatePagesSiteCommand(G.IApi client) : base(
            name: "repos",
            description: @"Configures a GitHub Pages site. For more information, see ""[About GitHub Pages](/github/working-with-github-pages/about-github-pages).""

The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(BuildType);
            Options.Add(Source);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var buildType = parseResult.GetRequiredValue(BuildType);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                buildType: buildType,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreatePagesSiteAsync(
                owner: owner,
                repo: repo,
                buildType: buildType,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}