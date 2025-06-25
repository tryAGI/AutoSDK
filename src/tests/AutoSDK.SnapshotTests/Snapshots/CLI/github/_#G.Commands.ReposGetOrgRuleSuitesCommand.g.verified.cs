//HintName: G.Commands.ReposGetOrgRuleSuitesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetOrgRuleSuitesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string? @ref,
            int? repositoryName,
            global::G.ReposGetOrgRuleSuitesTimePeriod? timePeriod,
            string? actorName,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RuleSuite> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> RepositoryName { get; } = new(
            name: "repositoryName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposGetOrgRuleSuitesTimePeriod?> TimePeriod { get; } = new(
            name: "timePeriod")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ActorName { get; } = new(
            name: "actorName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposGetOrgRuleSuitesRuleSuiteResult?> RuleSuiteResult { get; } = new(
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
        public ReposGetOrgRuleSuitesCommand(G.IApi client) : base(
            name: "repos",
            description: @"Lists suites of rule evaluations at the organization level.
For more information, see ""[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets).""")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(Ref);
            Options.Add(RepositoryName);
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
            var org = parseResult.GetRequiredValue(Org);
            var @ref = parseResult.GetRequiredValue(Ref);
            var repositoryName = parseResult.GetRequiredValue(RepositoryName);
            var timePeriod = parseResult.GetRequiredValue(TimePeriod);
            var actorName = parseResult.GetRequiredValue(ActorName);
            var ruleSuiteResult = parseResult.GetRequiredValue(RuleSuiteResult);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                org: org,
                @ref: @ref,
                repositoryName: repositoryName,
                timePeriod: timePeriod,
                actorName: actorName,
                ruleSuiteResult: ruleSuiteResult,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetOrgRuleSuitesAsync(
                org: org,
                @ref: @ref,
                repositoryName: repositoryName,
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