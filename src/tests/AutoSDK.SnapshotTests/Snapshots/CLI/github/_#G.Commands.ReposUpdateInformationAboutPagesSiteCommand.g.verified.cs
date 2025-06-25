//HintName: G.Commands.ReposUpdateInformationAboutPagesSiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateInformationAboutPagesSiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? cname,
            bool? httpsEnforced,
            global::G.ReposUpdateInformationAboutPagesSiteRequestBuildType? buildType,
            global::G.AnyOf<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? source,
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

        private global::System.CommandLine.Option<string?> Cname { get; } = new(
            name: "cname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HttpsEnforced { get; } = new(
            name: "httpsEnforced")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateInformationAboutPagesSiteRequestBuildType?> BuildType { get; } = new(
            name: "buildType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>?> Source { get; } = new(
            name: "source")
        {
            Description = "",
        };
        public ReposUpdateInformationAboutPagesSiteCommand(G.IApi client) : base(
            name: "repos",
            description: @"Updates information for a GitHub Pages site. For more information, see ""[About GitHub Pages](/github/working-with-github-pages/about-github-pages).

The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Cname);
            Options.Add(HttpsEnforced);
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
            var cname = parseResult.GetRequiredValue(Cname);
            var httpsEnforced = parseResult.GetRequiredValue(HttpsEnforced);
            var buildType = parseResult.GetRequiredValue(BuildType);
            var source = parseResult.GetRequiredValue(Source);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                cname: cname,
                httpsEnforced: httpsEnforced,
                buildType: buildType,
                source: source,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposUpdateInformationAboutPagesSiteAsync(
                owner: owner,
                repo: repo,
                cname: cname,
                httpsEnforced: httpsEnforced,
                buildType: buildType,
                source: source,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}