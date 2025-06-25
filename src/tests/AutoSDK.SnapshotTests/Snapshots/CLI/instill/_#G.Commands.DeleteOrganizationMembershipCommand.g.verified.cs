//HintName: G.Commands.DeleteOrganizationMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteOrganizationMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"Organization ID",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"User ID",
        };

        public DeleteOrganizationMembershipCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes a user membership within an organization.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(OrganizationId);
            Arguments.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.DeleteOrganizationMembershipAsync(
                organizationId: organizationId,
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}