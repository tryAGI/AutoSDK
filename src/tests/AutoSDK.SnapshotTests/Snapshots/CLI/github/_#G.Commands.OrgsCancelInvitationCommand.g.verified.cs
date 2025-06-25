//HintName: G.Commands.OrgsCancelInvitationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCancelInvitationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> InvitationId { get; } = new(
            name: "invitationId")
        {
            Description = "",
        };

        public OrgsCancelInvitationCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(InvitationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var invitationId = parseResult.GetRequiredValue(InvitationId);

            Validate(
                parseResult: parseResult,
                org: org,
                invitationId: invitationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsCancelInvitationAsync(
                org: org,
                invitationId: invitationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}