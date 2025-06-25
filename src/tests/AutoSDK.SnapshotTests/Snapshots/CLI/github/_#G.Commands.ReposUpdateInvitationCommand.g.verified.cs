//HintName: G.Commands.ReposUpdateInvitationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateInvitationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int invitationId,
            global::G.ReposUpdateInvitationRequestPermissions? permissions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RepositoryInvitation response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> InvitationId { get; } = new(
            name: "invitationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateInvitationRequestPermissions?> Permissions { get; } = new(
            name: "permissions")
        {
            Description = "",
        };
        public ReposUpdateInvitationCommand(G.IApi client) : base(
            name: "repos",
            description: @"")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(InvitationId);
            Options.Add(Permissions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var invitationId = parseResult.GetRequiredValue(InvitationId);
            var permissions = parseResult.GetRequiredValue(Permissions);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                invitationId: invitationId,
                permissions: permissions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateInvitationAsync(
                owner: owner,
                repo: repo,
                invitationId: invitationId,
                permissions: permissions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}