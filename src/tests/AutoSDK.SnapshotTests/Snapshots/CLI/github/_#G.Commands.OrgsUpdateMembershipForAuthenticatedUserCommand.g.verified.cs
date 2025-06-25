//HintName: G.Commands.OrgsUpdateMembershipForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdateMembershipForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrgMembership response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public OrgsUpdateMembershipForAuthenticatedUserCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Converts the authenticated user to an active member of the organization, if that user has a pending invitation from the organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(State);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                org: org,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsUpdateMembershipForAuthenticatedUserAsync(
                org: org,
                state: state,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}