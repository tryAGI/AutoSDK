//HintName: G.Commands.SecurityAdvisoriesListOrgRepositoryAdvisoriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesListOrgRepositoryAdvisoriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection? direction,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int? perPage,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState? state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisory> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort?> Sort { get; } = new(
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

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public SecurityAdvisoriesListOrgRepositoryAdvisoriesCommand(G.IApi client) : base(
            name: "security",
            description: @"Lists repository security advisories for an organization.

The authenticated user must be an owner or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
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
            var org = parseResult.GetRequiredValue(Org);
            var direction = parseResult.GetRequiredValue(Direction);
            var sort = parseResult.GetRequiredValue(Sort);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                org: org,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesListOrgRepositoryAdvisoriesAsync(
                org: org,
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