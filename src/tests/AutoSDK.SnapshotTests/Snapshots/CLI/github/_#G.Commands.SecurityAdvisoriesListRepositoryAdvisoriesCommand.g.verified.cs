//HintName: G.Commands.SecurityAdvisoriesListRepositoryAdvisoriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesListRepositoryAdvisoriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int? perPage,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesState? state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisory> response,
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

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListRepositoryAdvisoriesState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public SecurityAdvisoriesListRepositoryAdvisoriesCommand(G.IApi client) : base(
            name: "security",
            description: @"Lists security advisories in a repository.

The authenticated user can access unpublished security advisories from a repository if they are a security manager or administrator of that repository, or if they are a collaborator on any security advisory.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Direction);
            Options.Add(Sort);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(PerPage);
            Options.Add(State);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var direction = parseResult.GetRequiredValue(Direction);
            var sort = parseResult.GetRequiredValue(Sort);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesListRepositoryAdvisoriesAsync(
                owner: owner,
                repo: repo,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}