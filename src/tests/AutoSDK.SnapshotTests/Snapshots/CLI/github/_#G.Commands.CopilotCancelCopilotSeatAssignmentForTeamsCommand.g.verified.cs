//HintName: G.Commands.CopilotCancelCopilotSeatAssignmentForTeamsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopilotCancelCopilotSeatAssignmentForTeamsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> selectedTeams,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CopilotCancelCopilotSeatAssignmentForTeamsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> SelectedTeams { get; } = new(
            name: "selectedTeams")
        {
            Description = "",
        };

        public CopilotCancelCopilotSeatAssignmentForTeamsCommand(G.IApi client) : base(
            name: "copilot",
            description: @"> [!NOTE]
> This endpoint is in beta and is subject to change.

Cancels the Copilot seat assignment for all members of each team specified.
This will cause the members of the specified team(s) to lose access to GitHub Copilot at the end of the current billing cycle, and the organization will not be billed further for those users.

For more information about Copilot pricing, see ""[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)"".

For more information about disabling access to Copilot Business or Enterprise, see ""[Revoking access to GitHub Copilot for specific users in your organization](https://docs.github.com/copilot/managing-copilot/managing-access-for-copilot-in-your-organization#revoking-access-to-github-copilot-for-specific-users-in-your-organization)"".

Only organization owners can cancel Copilot seats for their organization members.

OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SelectedTeams);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var selectedTeams = parseResult.GetRequiredValue(SelectedTeams);

            Validate(
                parseResult: parseResult,
                org: org,
                selectedTeams: selectedTeams,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Copilot.CopilotCancelCopilotSeatAssignmentForTeamsAsync(
                org: org,
                selectedTeams: selectedTeams,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}