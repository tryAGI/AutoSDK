//HintName: G.Commands.CopilotAddCopilotSeatsForUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopilotAddCopilotSeatsForUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CopilotAddCopilotSeatsForUsersResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> SelectedUsernames { get; } = new(
            name: "selectedUsernames")
        {
            Description = "",
        };

        public CopilotAddCopilotSeatsForUsersCommand(G.IApi client) : base(
            name: "copilot",
            description: @"> [!NOTE]
> This endpoint is in beta and is subject to change.

Purchases a GitHub Copilot seat for each user specified.
The organization will be billed accordingly. For more information about Copilot pricing, see ""[Pricing for GitHub Copilot](https://docs.github.com/billing/managing-billing-for-github-copilot/about-billing-for-github-copilot#about-billing-for-github-copilot)"".

Only organization owners can add Copilot seats for their organization members.

In order for an admin to use this endpoint, the organization must have a Copilot Business or Enterprise subscription and a configured suggestion matching policy.
For more information about setting up a Copilot subscription, see ""[Setting up a Copilot subscription for your organization](https://docs.github.com/billing/managing-billing-for-github-copilot/managing-your-github-copilot-subscription-for-your-organization-or-enterprise)"".
For more information about setting a suggestion matching policy, see ""[Configuring suggestion matching policies for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-policies-for-github-copilot-in-your-organization#configuring-suggestion-matching-policies-for-github-copilot-in-your-organization)"".

The response will contain the total number of new seats that were created and existing seats that were refreshed.

OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SelectedUsernames);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var selectedUsernames = parseResult.GetRequiredValue(SelectedUsernames);

            Validate(
                parseResult: parseResult,
                org: org,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Copilot.CopilotAddCopilotSeatsForUsersAsync(
                org: org,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}