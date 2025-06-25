//HintName: G.Commands.DeleteUserMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteUserMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"",
        };

        public DeleteUserMembershipCommand(G.IApi client) : base(
            name: "delete",
            description: @"Accesses and deletes a user membership by parent and membership IDs.")
        {
            _client = client;

            Arguments.Add(UserId);
            Arguments.Add(OrganizationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var organizationId = parseResult.GetRequiredValue(OrganizationId);

            Validate(
                parseResult: parseResult,
                userId: userId,
                organizationId: organizationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.DeleteUserMembershipAsync(
                userId: userId,
                organizationId: organizationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}