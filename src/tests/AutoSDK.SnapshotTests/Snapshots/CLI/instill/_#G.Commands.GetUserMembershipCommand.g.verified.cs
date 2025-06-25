//HintName: G.Commands.GetUserMembershipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUserMembershipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string organizationId,
            global::G.GetUserMembershipView? view,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetUserMembershipResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"User ID",
        };

        private global::System.CommandLine.Argument<string> OrganizationId { get; } = new(
            name: "organizationId")
        {
            Description = @"Organization ID",
        };

        private global::System.CommandLine.Option<global::G.GetUserMembershipView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired resource view in the response.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.",
        };
        public GetUserMembershipCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns the details of the relationship between a user and an
organization. The authenticated must match the membership parent.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);
            Arguments.Add(OrganizationId);
            Options.Add(View);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var organizationId = parseResult.GetRequiredValue(OrganizationId);
            var view = parseResult.GetRequiredValue(View);

            Validate(
                parseResult: parseResult,
                userId: userId,
                organizationId: organizationId,
                view: view,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.GetUserMembershipAsync(
                userId: userId,
                organizationId: organizationId,
                view: view,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}