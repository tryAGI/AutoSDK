//HintName: G.Commands.ReposGetRepoRulesetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetRepoRulesetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int? perPage,
            int? page,
            bool? includesParents,
            string? targets,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RepositoryRuleset> response,
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

        private global::System.CommandLine.Option<bool?> IncludesParents { get; } = new(
            name: "includesParents")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Targets { get; } = new(
            name: "targets")
        {
            Description = "",
        };
        public ReposGetRepoRulesetsCommand(G.IApi client) : base(
            name: "repos",
            description: @"Get all the rulesets for a repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(IncludesParents);
            Options.Add(Targets);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var includesParents = parseResult.GetRequiredValue(IncludesParents);
            var targets = parseResult.GetRequiredValue(Targets);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                includesParents: includesParents,
                targets: targets,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetRepoRulesetsAsync(
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                includesParents: includesParents,
                targets: targets,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}