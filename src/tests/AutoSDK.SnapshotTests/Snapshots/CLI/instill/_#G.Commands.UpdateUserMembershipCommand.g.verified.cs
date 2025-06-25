//HintName: G.Commands.UpdateUserMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateUserMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string organizationId,
            string updateMask,
            global::G.MembershipState state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateUserMembershipResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UpdateMask { get; } = new(
            name: "updateMask")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.MembershipState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        public UpdateUserMembershipCommand(G.IApi client) : base(
            name: "update",
            description: @"Accesses and updates a user membership by parent and membership IDs.")
        {
            _client = client;

            Arguments.Add(UserId);
            Arguments.Add(OrganizationId);
            Arguments.Add(UpdateMask);
            Arguments.Add(State);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var updateMask = parseResult.GetRequiredValue(UpdateMask);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                userId: userId,
                organizationId: organizationId,
                updateMask: updateMask,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.UpdateUserMembershipAsync(
                userId: userId,
                organizationId: organizationId,
                updateMask: updateMask,
                state: state,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}