//HintName: G.Commands.CopilotUsageMetricsForTeamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopilotUsageMetricsForTeamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            string? since,
            string? until,
            int? page,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TeamSlug { get; } = new(
            name: "teamSlug")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Until { get; } = new(
            name: "until")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };
        public CopilotUsageMetricsForTeamCommand(G.IApi client) : base(
            name: "copilot",
            description: @"> [!NOTE]
> This endpoint is in beta and is subject to change.

You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDE
for users within a team, with a further breakdown of suggestions, acceptances, and number of active users by editor and language for each day.
See the response schema tab for detailed metrics definitions.

The response contains metrics for up to 28 days prior. Usage metrics are processed once per day for the previous day,
and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,
they must have telemetry enabled in their IDE.

> [!NOTE]
> This endpoint will only return results for a given day if the team had five or more members with active Copilot licenses, as evaluated at the end of that day.

Organization owners for the organization that contains this team, and owners and billing managers of the parent enterprise can view Copilot usage metrics for a team.

OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot`, `read:org`, or `read:enterprise` scopes to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Options.Add(Since);
            Options.Add(Until);
            Options.Add(Page);
            Options.Add(PerPage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var since = parseResult.GetRequiredValue(Since);
            var until = parseResult.GetRequiredValue(Until);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                since: since,
                until: until,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Copilot.CopilotUsageMetricsForTeamAsync(
                org: org,
                teamSlug: teamSlug,
                since: since,
                until: until,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}