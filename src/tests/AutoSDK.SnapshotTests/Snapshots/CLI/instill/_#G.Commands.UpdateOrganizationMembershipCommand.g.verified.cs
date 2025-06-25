//HintName: G.Commands.UpdateOrganizationMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateOrganizationMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            string userId,
            string updateMask,
            string role,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateOrganizationMembershipResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UpdateMask { get; } = new(
            name: "updateMask")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        public UpdateOrganizationMembershipCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates a user membership within an organization.")
        {
            _client = client;

            Arguments.Add(OrganizationId);
            Arguments.Add(UserId);
            Arguments.Add(UpdateMask);
            Arguments.Add(Role);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var userId = parseResult.GetRequiredValue(UserId);
            var updateMask = parseResult.GetRequiredValue(UpdateMask);
            var role = parseResult.GetRequiredValue(Role);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                role: role,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.UpdateOrganizationMembershipAsync(
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                role: role,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}