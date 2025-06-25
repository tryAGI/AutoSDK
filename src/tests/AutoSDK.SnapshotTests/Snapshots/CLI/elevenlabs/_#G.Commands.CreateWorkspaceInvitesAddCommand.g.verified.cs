//HintName: G.Commands.CreateWorkspaceInvitesAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceInvitesAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string email,
            global::System.Collections.Generic.IList<string>? groupIds,
            global::G.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission? workspacePermission,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddWorkspaceInviteResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> GroupIds { get; } = new(
            name: "groupIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission?> WorkspacePermission { get; } = new(
            name: "workspacePermission")
        {
            Description = "",
        };
        public CreateWorkspaceInvitesAddCommand(G.IApi client) : base(
            name: "create",
            description: @"Sends an email invitation to join your workspace to the provided email. If the user doesn't have an account they will be prompted to create one. If the user accepts this invite they will be added as a user to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators. If the user is already in the workspace a 400 error will be returned.")
        {
            _client = client;

            Arguments.Add(Email);
            Options.Add(XiApiKey);
            Options.Add(GroupIds);
            Options.Add(WorkspacePermission);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var email = parseResult.GetRequiredValue(Email);
            var groupIds = parseResult.GetRequiredValue(GroupIds);
            var workspacePermission = parseResult.GetRequiredValue(WorkspacePermission);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                email: email,
                groupIds: groupIds,
                workspacePermission: workspacePermission,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceInvitesAddAsync(
                xiApiKey: xiApiKey,
                email: email,
                groupIds: groupIds,
                workspacePermission: workspacePermission,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}