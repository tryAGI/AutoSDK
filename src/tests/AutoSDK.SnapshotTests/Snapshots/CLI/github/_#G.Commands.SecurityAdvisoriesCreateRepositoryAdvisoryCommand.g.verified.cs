//HintName: G.Commands.SecurityAdvisoriesCreateRepositoryAdvisoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesCreateRepositoryAdvisoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string summary,
            string description,
            string? cveId,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie> vulnerabilities,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>? credits,
            global::G.RepositoryAdvisoryCreateSeverity? severity,
            string? cvssVectorString,
            bool? startPrivateFork,
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

        private global::System.CommandLine.Argument<string> Summary { get; } = new(
            name: "summary")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie>> Vulnerabilities { get; } = new(
            name: "vulnerabilities")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CveId { get; } = new(
            name: "cveId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> CweIds { get; } = new(
            name: "cweIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>?> Credits { get; } = new(
            name: "credits")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RepositoryAdvisoryCreateSeverity?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CvssVectorString { get; } = new(
            name: "cvssVectorString")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> StartPrivateFork { get; } = new(
            name: "startPrivateFork")
        {
            Description = "",
        };
        public SecurityAdvisoriesCreateRepositoryAdvisoryCommand(G.IApi client) : base(
            name: "security",
            description: @"Creates a new repository security advisory.

In order to create a draft repository security advisory, the authenticated user must be a security manager or administrator of that repository.

OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Summary);
            Arguments.Add(Description);
            Arguments.Add(Vulnerabilities);
            Options.Add(CveId);
            Options.Add(CweIds);
            Options.Add(Credits);
            Options.Add(Severity);
            Options.Add(CvssVectorString);
            Options.Add(StartPrivateFork);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var summary = parseResult.GetRequiredValue(Summary);
            var description = parseResult.GetRequiredValue(Description);
            var cveId = parseResult.GetRequiredValue(CveId);
            var vulnerabilities = parseResult.GetRequiredValue(Vulnerabilities);
            var cweIds = parseResult.GetRequiredValue(CweIds);
            var credits = parseResult.GetRequiredValue(Credits);
            var severity = parseResult.GetRequiredValue(Severity);
            var cvssVectorString = parseResult.GetRequiredValue(CvssVectorString);
            var startPrivateFork = parseResult.GetRequiredValue(StartPrivateFork);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                summary: summary,
                description: description,
                cveId: cveId,
                vulnerabilities: vulnerabilities,
                cweIds: cweIds,
                credits: credits,
                severity: severity,
                cvssVectorString: cvssVectorString,
                startPrivateFork: startPrivateFork,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesCreateRepositoryAdvisoryAsync(
                owner: owner,
                repo: repo,
                summary: summary,
                description: description,
                cveId: cveId,
                vulnerabilities: vulnerabilities,
                cweIds: cweIds,
                credits: credits,
                severity: severity,
                cvssVectorString: cvssVectorString,
                startPrivateFork: startPrivateFork,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}