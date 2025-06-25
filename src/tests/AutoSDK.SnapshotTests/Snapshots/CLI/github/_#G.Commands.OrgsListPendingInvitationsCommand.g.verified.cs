//HintName: G.Commands.OrgsListPendingInvitationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsListPendingInvitationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            global::G.OrgsListPendingInvitationsRole? role,
            global::G.OrgsListPendingInvitationsInvitationSource? invitationSource,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.OrganizationInvitation> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
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

        private global::System.CommandLine.Option<global::G.OrgsListPendingInvitationsRole?> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsListPendingInvitationsInvitationSource?> InvitationSource { get; } = new(
            name: "invitationSource")
        {
            Description = "",
        };
        public OrgsListPendingInvitationsCommand(G.IApi client) : base(
            name: "orgs",
            description: @"The return hash contains a `role` field which refers to the Organization
Invitation role and will be one of the following values: `direct_member`, `admin`,
`billing_manager`, or `hiring_manager`. If the invitee is not a GitHub
member, the `login` field in the return hash will be `null`.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Role);
            Options.Add(InvitationSource);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var role = parseResult.GetRequiredValue(Role);
            var invitationSource = parseResult.GetRequiredValue(InvitationSource);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                role: role,
                invitationSource: invitationSource,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsListPendingInvitationsAsync(
                org: org,
                perPage: perPage,
                page: page,
                role: role,
                invitationSource: invitationSource,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}