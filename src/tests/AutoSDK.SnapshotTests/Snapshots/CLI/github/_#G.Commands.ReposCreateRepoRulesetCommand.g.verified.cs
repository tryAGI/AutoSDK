//HintName: G.Commands.ReposCreateRepoRulesetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateRepoRulesetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string name,
            global::G.ReposCreateRepoRulesetRequestTarget? target,
            global::G.RepositoryRuleEnforcement enforcement,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? bypassActors,
            global::G.RepositoryRulesetConditions? conditions,
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? rules,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RepositoryRuleset response,
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

        private global::System.CommandLine.Option<global::G.ReposCreateRepoRulesetRequestTarget?> Target { get; } = new(
            name: "target")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>?> BypassActors { get; } = new(
            name: "bypassActors")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RepositoryRulesetConditions?> Conditions { get; } = new(
            name: "conditions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryRule>?> Rules { get; } = new(
            name: "rules")
        {
            Description = "",
        };
        public ReposCreateRepoRulesetCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create a ruleset for a repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
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
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);
            var target = parseResult.GetRequiredValue(Target);
            var enforcement = parseResult.GetRequiredValue(Enforcement);
            var bypassActors = parseResult.GetRequiredValue(BypassActors);
            var conditions = parseResult.GetRequiredValue(Conditions);
            var rules = parseResult.GetRequiredValue(Rules);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                target: target,
                enforcement: enforcement,
                bypassActors: bypassActors,
                conditions: conditions,
                rules: rules,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateRepoRulesetAsync(
                owner: owner,
                repo: repo,
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