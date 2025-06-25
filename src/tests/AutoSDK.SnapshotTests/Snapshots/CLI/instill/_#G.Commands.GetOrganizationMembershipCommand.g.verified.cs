//HintName: G.Commands.GetOrganizationMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetOrganizationMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string organizationId,
            string userId,
            global::G.GetOrganizationMembershipView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetOrganizationMembershipResponse response,
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

        private global::System.CommandLine.Option<global::G.GetOrganizationMembershipView?> View { get; } = new(
            name: "view")
        {
            Description = "",
        };
        public GetOrganizationMembershipCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns the details of a user membership within an organization.")
        {
            _client = client;

            Arguments.Add(OrganizationId);
            Arguments.Add(UserId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var userId = parseResult.GetRequiredValue(UserId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                organizationId: organizationId,
                userId: userId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.GetOrganizationMembershipAsync(
                organizationId: organizationId,
                userId: userId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}