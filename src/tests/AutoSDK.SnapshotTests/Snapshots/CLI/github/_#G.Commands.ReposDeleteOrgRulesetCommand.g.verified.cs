//HintName: G.Commands.ReposDeleteOrgRulesetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteOrgRulesetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int rulesetId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RulesetId { get; } = new(
            name: "rulesetId")
        {
            Description = "",
        };

        public ReposDeleteOrgRulesetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Delete a ruleset for an organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RulesetId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var rulesetId = parseResult.GetRequiredValue(RulesetId);

            Validate(
                parseResult: parseResult,
                org: org,
                rulesetId: rulesetId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteOrgRulesetAsync(
                org: org,
                rulesetId: rulesetId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}