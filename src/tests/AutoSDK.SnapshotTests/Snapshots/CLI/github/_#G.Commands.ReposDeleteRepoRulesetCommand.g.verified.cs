//HintName: G.Commands.ReposDeleteRepoRulesetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteRepoRulesetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int rulesetId,
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

        private global::System.CommandLine.Argument<int> RulesetId { get; } = new(
            name: "rulesetId")
        {
            Description = "",
        };

        public ReposDeleteRepoRulesetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Delete a ruleset for a repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RulesetId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var rulesetId = parseResult.GetRequiredValue(RulesetId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteRepoRulesetAsync(
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}