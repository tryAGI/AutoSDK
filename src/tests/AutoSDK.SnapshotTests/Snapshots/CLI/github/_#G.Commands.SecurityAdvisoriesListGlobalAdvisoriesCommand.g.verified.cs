//HintName: G.Commands.SecurityAdvisoriesListGlobalAdvisoriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecurityAdvisoriesListGlobalAdvisoriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? ghsaId,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesType? type,
            string? cveId,
            global::G.SecurityAdvisoryEcosystems? ecosystem,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity? severity,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? cwes,
            bool? isWithdrawn,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? affects,
            string? published,
            string? updated,
            string? modified,
            string? epssPercentage,
            string? epssPercentile,
            string? before,
            string? after,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection? direction,
            int? perPage,
            global::G.SecurityAdvisoriesListGlobalAdvisoriesSort? sort,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.GlobalAdvisory> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> GhsaId { get; } = new(
            name: "ghsaId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListGlobalAdvisoriesType?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CveId { get; } = new(
            name: "cveId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoryEcosystems?> Ecosystem { get; } = new(
            name: "ecosystem")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListGlobalAdvisoriesSeverity?> Severity { get; } = new(
            name: "severity")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>?> Cwes { get; } = new(
            name: "cwes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsWithdrawn { get; } = new(
            name: "isWithdrawn")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>?> Affects { get; } = new(
            name: "affects")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Published { get; } = new(
            name: "published")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Updated { get; } = new(
            name: "updated")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Modified { get; } = new(
            name: "modified")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EpssPercentage { get; } = new(
            name: "epssPercentage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EpssPercentile { get; } = new(
            name: "epssPercentile")
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

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListGlobalAdvisoriesDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecurityAdvisoriesListGlobalAdvisoriesSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };
        public SecurityAdvisoriesListGlobalAdvisoriesCommand(G.IApi client) : base(
            name: "security",
            description: @"Lists all global security advisories that match the specified parameters. If no other parameters are defined, the request will return only GitHub-reviewed advisories that are not malware.

By default, all responses will exclude advisories for malware, because malware are not standard vulnerabilities. To list advisories for malware, you must include the `type` parameter in your request, with the value `malware`. For more information about the different types of security advisories, see ""[About the GitHub Advisory database](https://docs.github.com/code-security/security-advisories/global-security-advisories/about-the-github-advisory-database#about-types-of-security-advisories).""")
        {
            _client = client;

            Options.Add(GhsaId);
            Options.Add(Type);
            Options.Add(CveId);
            Options.Add(Ecosystem);
            Options.Add(Severity);
            Options.Add(Cwes);
            Options.Add(IsWithdrawn);
            Options.Add(Affects);
            Options.Add(Published);
            Options.Add(Updated);
            Options.Add(Modified);
            Options.Add(EpssPercentage);
            Options.Add(EpssPercentile);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Sort);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ghsaId = parseResult.GetRequiredValue(GhsaId);
            var type = parseResult.GetRequiredValue(Type);
            var cveId = parseResult.GetRequiredValue(CveId);
            var ecosystem = parseResult.GetRequiredValue(Ecosystem);
            var severity = parseResult.GetRequiredValue(Severity);
            var cwes = parseResult.GetRequiredValue(Cwes);
            var isWithdrawn = parseResult.GetRequiredValue(IsWithdrawn);
            var affects = parseResult.GetRequiredValue(Affects);
            var published = parseResult.GetRequiredValue(Published);
            var updated = parseResult.GetRequiredValue(Updated);
            var modified = parseResult.GetRequiredValue(Modified);
            var epssPercentage = parseResult.GetRequiredValue(EpssPercentage);
            var epssPercentile = parseResult.GetRequiredValue(EpssPercentile);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var sort = parseResult.GetRequiredValue(Sort);

            Validate(
                parseResult: parseResult,
                ghsaId: ghsaId,
                type: type,
                cveId: cveId,
                ecosystem: ecosystem,
                severity: severity,
                cwes: cwes,
                isWithdrawn: isWithdrawn,
                affects: affects,
                published: published,
                updated: updated,
                modified: modified,
                epssPercentage: epssPercentage,
                epssPercentile: epssPercentile,
                before: before,
                after: after,
                direction: direction,
                perPage: perPage,
                sort: sort,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecurityAdvisories.SecurityAdvisoriesListGlobalAdvisoriesAsync(
                ghsaId: ghsaId,
                type: type,
                cveId: cveId,
                ecosystem: ecosystem,
                severity: severity,
                cwes: cwes,
                isWithdrawn: isWithdrawn,
                affects: affects,
                published: published,
                updated: updated,
                modified: modified,
                epssPercentage: epssPercentage,
                epssPercentile: epssPercentile,
                before: before,
                after: after,
                direction: direction,
                perPage: perPage,
                sort: sort,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}