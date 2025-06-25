//HintName: G.Commands.ReposUpdateOrgRulesetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateOrgRulesetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int rulesetId,
            string? name,
            global::G.ReposUpdateOrgRulesetRequestTarget? target,
            global::G.RepositoryRuleEnforcement? enforcement,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? bypassActors,
            global::G.OrgRulesetConditions? conditions,
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? rules,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RepositoryRuleset response,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateOrgRulesetRequestTarget?> Target { get; } = new(
            name: "target")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RepositoryRuleEnforcement?> Enforcement { get; } = new(
            name: "enforcement")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>?> BypassActors { get; } = new(
            name: "bypassActors")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgRulesetConditions?> Conditions { get; } = new(
            name: "conditions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryRule>?> Rules { get; } = new(
            name: "rules")
        {
            Description = "",
        };
        public ReposUpdateOrgRulesetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Update a ruleset for an organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RulesetId);
            Options.Add(Name);
            Options.Add(Target);
            Options.Add(Enforcement);
            Options.Add(BypassActors);
            Options.Add(Conditions);
            Options.Add(Rules);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var rulesetId = parseResult.GetRequiredValue(RulesetId);
            var name = parseResult.GetRequiredValue(Name);
            var target = parseResult.GetRequiredValue(Target);
            var enforcement = parseResult.GetRequiredValue(Enforcement);
            var bypassActors = parseResult.GetRequiredValue(BypassActors);
            var conditions = parseResult.GetRequiredValue(Conditions);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                org: org,
                rulesetId: rulesetId,
                name: name,
                target: target,
                enforcement: enforcement,
                bypassActors: bypassActors,
                conditions: conditions,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateOrgRulesetAsync(
                org: org,
                rulesetId: rulesetId,
                name: name,
                target: target,
                enforcement: enforcement,
                bypassActors: bypassActors,
                conditions: conditions,
                rules: rules,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}