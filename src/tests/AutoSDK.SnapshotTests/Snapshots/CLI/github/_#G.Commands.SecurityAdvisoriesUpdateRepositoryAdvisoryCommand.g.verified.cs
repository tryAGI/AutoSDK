//HintName: G.Commands.SecurityAdvisoriesUpdateRepositoryAdvisoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesUpdateRepositoryAdvisoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string ghsaId,
            string? summary,
            string? description,
            string? cveId,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>? vulnerabilities,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>? credits,
            global::G.RepositoryAdvisoryUpdateSeverity? severity,
            string? cvssVectorString,
            global::G.RepositoryAdvisoryUpdateState? state,
            global::System.Collections.Generic.IList<string>? collaboratingUsers,
            global::System.Collections.Generic.IList<string>? collaboratingTeams,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RepositoryAdvisory response,
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

        private global::System.CommandLine.Argument<string> GhsaId { get; } = new(
            name: "ghsaId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Summary { get; } = new(
            name: "summary")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CveId { get; } = new(
            name: "cveId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>?> Vulnerabilities { get; } = new(
            name: "vulnerabilities")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> CweIds { get; } = new(
            name: "cweIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>?> Credits { get; } = new(
            name: "credits")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RepositoryAdvisoryUpdateSeverity?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CvssVectorString { get; } = new(
            name: "cvssVectorString")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RepositoryAdvisoryUpdateState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> CollaboratingUsers { get; } = new(
            name: "collaboratingUsers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> CollaboratingTeams { get; } = new(
            name: "collaboratingTeams")
        {
            Description = "",
        };
        public SecurityAdvisoriesUpdateRepositoryAdvisoryCommand(G.IApi client) : base(
            name: "security",
            description: @"Update a repository security advisory using its GitHub Security Advisory (GHSA) identifier.

In order to update any security advisory, the authenticated user must be a security manager or administrator of that repository,
or a collaborator on the repository security advisory.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(GhsaId);
            Options.Add(Summary);
            Options.Add(Description);
            Options.Add(CveId);
            Options.Add(Vulnerabilities);
            Options.Add(CweIds);
            Options.Add(Credits);
            Options.Add(Severity);
            Options.Add(CvssVectorString);
            Options.Add(State);
            Options.Add(CollaboratingUsers);
            Options.Add(CollaboratingTeams);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var ghsaId = parseResult.GetRequiredValue(GhsaId);
            var summary = parseResult.GetRequiredValue(Summary);
            var description = parseResult.GetRequiredValue(Description);
            var cveId = parseResult.GetRequiredValue(CveId);
            var vulnerabilities = parseResult.GetRequiredValue(Vulnerabilities);
            var cweIds = parseResult.GetRequiredValue(CweIds);
            var credits = parseResult.GetRequiredValue(Credits);
            var severity = parseResult.GetRequiredValue(Severity);
            var cvssVectorString = parseResult.GetRequiredValue(CvssVectorString);
            var state = parseResult.GetRequiredValue(State);
            var collaboratingUsers = parseResult.GetRequiredValue(CollaboratingUsers);
            var collaboratingTeams = parseResult.GetRequiredValue(CollaboratingTeams);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                summary: summary,
                description: description,
                cveId: cveId,
                vulnerabilities: vulnerabilities,
                cweIds: cweIds,
                credits: credits,
                severity: severity,
                cvssVectorString: cvssVectorString,
                state: state,
                collaboratingUsers: collaboratingUsers,
                collaboratingTeams: collaboratingTeams,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesUpdateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                ghsaId: ghsaId,
                summary: summary,
                description: description,
                cveId: cveId,
                vulnerabilities: vulnerabilities,
                cweIds: cweIds,
                credits: credits,
                severity: severity,
                cvssVectorString: cvssVectorString,
                state: state,
                collaboratingUsers: collaboratingUsers,
                collaboratingTeams: collaboratingTeams,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}