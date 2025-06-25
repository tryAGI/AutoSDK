//HintName: G.Commands.ReposGetRepoRuleSuitesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetRepoRuleSuitesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? @ref,
            global::G.ReposGetRepoRuleSuitesTimePeriod? timePeriod,
            string? actorName,
            global::G.ReposGetRepoRuleSuitesRuleSuiteResult? ruleSuiteResult,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RuleSuite> response,
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

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposGetRepoRuleSuitesTimePeriod?> TimePeriod { get; } = new(
            name: "timePeriod")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ActorName { get; } = new(
            name: "actorName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposGetRepoRuleSuitesRuleSuiteResult?> RuleSuiteResult { get; } = new(
            name: "ruleSuiteResult")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public ReposGetRepoRuleSuitesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Lists suites of rule evaluations at the repository level.
For more information, see ""[Managing rulesets for a repository](https://docs.github.com/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/managing-rulesets-for-a-repository#viewing-insights-for-rulesets).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Ref);
            Options.Add(TimePeriod);
            Options.Add(ActorName);
            Options.Add(RuleSuiteResult);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var timePeriod = parseResult.GetRequiredValue(TimePeriod);
            var actorName = parseResult.GetRequiredValue(ActorName);
            var ruleSuiteResult = parseResult.GetRequiredValue(RuleSuiteResult);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                timePeriod: timePeriod,
                actorName: actorName,
                ruleSuiteResult: ruleSuiteResult,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetRepoRuleSuitesAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                timePeriod: timePeriod,
                actorName: actorName,
                ruleSuiteResult: ruleSuiteResult,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}