//HintName: G.Commands.ReposGetRepoRuleSuiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetRepoRuleSuiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int ruleSuiteId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RuleSuite2 response,
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

        private global::System.CommandLine.Argument<int> RuleSuiteId { get; } = new(
            name: "ruleSuiteId")
        {
            Description = "",
        };

        public ReposGetRepoRuleSuiteCommand(G.IApi client) : base(
            name: "repos",
            description: @"Gets information about a suite of rule evaluations from within a repository.
For more information, see ""[Managing rulesets for a repository](https://docs.github.com/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/managing-rulesets-for-a-repository#viewing-insights-for-rulesets).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RuleSuiteId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var ruleSuiteId = parseResult.GetRequiredValue(RuleSuiteId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                ruleSuiteId: ruleSuiteId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetRepoRuleSuiteAsync(
                owner: owner,
                repo: repo,
                ruleSuiteId: ruleSuiteId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}