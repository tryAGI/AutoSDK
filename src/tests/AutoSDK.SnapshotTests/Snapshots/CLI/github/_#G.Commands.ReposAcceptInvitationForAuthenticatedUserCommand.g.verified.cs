//HintName: G.Commands.ReposAcceptInvitationForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposAcceptInvitationForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> InvitationId { get; } = new(
            name: "invitationId")
        {
            Description = "",
        };

        public ReposAcceptInvitationForAuthenticatedUserCommand(G.IApi client) : base(
            name: "repos",
            description: @"")
        {
            _client = client;

            Arguments.Add(InvitationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var invitationId = parseResult.GetRequiredValue(InvitationId);

            Validate(
                parseResult: parseResult,
                invitationId: invitationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposAcceptInvitationForAuthenticatedUserAsync(
                invitationId: invitationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}