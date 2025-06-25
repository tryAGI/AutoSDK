//HintName: G.Commands.ReposUpdateStatusCheckProtectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateStatusCheckProtectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string branch,
            bool? strict,
            global::System.Collections.Generic.IList<string>? contexts,
            global::System.Collections.Generic.IList<global::G.ReposUpdateStatusCheckProtectionRequestCheck>? checks,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.StatusCheckPolicy response,
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

        private global::System.CommandLine.Argument<string> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Strict { get; } = new(
            name: "strict")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Contexts { get; } = new(
            name: "contexts")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ReposUpdateStatusCheckProtectionRequestCheck>?> Checks { get; } = new(
            name: "checks")
        {
            Description = "",
        };
        public ReposUpdateStatusCheckProtectionCommand(G.IApi client) : base(
            name: "repos",
            description: @"Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

Updating required status checks requires admin or owner permissions to the repository and branch protection to be enabled.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Branch);
            Options.Add(Strict);
            Options.Add(Contexts);
            Options.Add(Checks);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var branch = parseResult.GetRequiredValue(Branch);
            var strict = parseResult.GetRequiredValue(Strict);
            var contexts = parseResult.GetRequiredValue(Contexts);
            var checks = parseResult.GetRequiredValue(Checks);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                branch: branch,
                strict: strict,
                contexts: contexts,
                checks: checks,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateStatusCheckProtectionAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                strict: strict,
                contexts: contexts,
                checks: checks,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}