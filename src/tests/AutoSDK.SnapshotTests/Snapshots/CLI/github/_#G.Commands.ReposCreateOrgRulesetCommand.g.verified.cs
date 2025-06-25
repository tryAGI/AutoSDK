//HintName: G.Commands.ReposCreateOrgRulesetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateOrgRulesetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            global::G.ReposCreateOrgRulesetRequestTarget? target,
            global::G.RepositoryRuleEnforcement enforcement,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.RepositoryRuleEnforcement> Enforcement { get; } = new(
            name: "enforcement")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateOrgRulesetRequestTarget?> Target { get; } = new(
            name: "target")
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
        public ReposCreateOrgRulesetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create a repository ruleset for an organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Arguments.Add(Enforcement);
            Options.Add(Target);
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
            var name = parseResult.GetRequiredValue(Name);
            var target = parseResult.GetRequiredValue(Target);
            var enforcement = parseResult.GetRequiredValue(Enforcement);
            var bypassActors = parseResult.GetRequiredValue(BypassActors);
            var conditions = parseResult.GetRequiredValue(Conditions);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                target: target,
                enforcement: enforcement,
                bypassActors: bypassActors,
                conditions: conditions,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateOrgRulesetAsync(
                org: org,
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