//HintName: G.Commands.ReposGetOrgRuleSuiteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetOrgRuleSuiteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int ruleSuiteId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RuleSuite2 response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RuleSuiteId { get; } = new(
            name: "ruleSuiteId")
        {
            Description = "",
        };

        public ReposGetOrgRuleSuiteCommand(G.IApi client) : base(
            name: "repos",
            description: @"Gets information about a suite of rule evaluations from within an organization.
For more information, see ""[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets).""")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RuleSuiteId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var ruleSuiteId = parseResult.GetRequiredValue(RuleSuiteId);

            Validate(
                parseResult: parseResult,
                org: org,
                ruleSuiteId: ruleSuiteId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetOrgRuleSuiteAsync(
                org: org,
                ruleSuiteId: ruleSuiteId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}