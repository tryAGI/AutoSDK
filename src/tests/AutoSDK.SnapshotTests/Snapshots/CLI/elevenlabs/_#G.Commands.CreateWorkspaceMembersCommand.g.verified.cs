//HintName: G.Commands.CreateWorkspaceMembersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceMembersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string email,
            bool? isLocked,
            global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? workspaceRole,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateWorkspaceMemberResponseModel response,
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

        private global::System.CommandLine.Option<bool?> IsLocked { get; } = new(
            name: "isLocked")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole?> WorkspaceRole { get; } = new(
            name: "workspaceRole")
        {
            Description = "",
        };
        public CreateWorkspaceMembersCommand(G.IApi client) : base(
            name: "create",
            description: @"Updates attributes of a workspace member. Apart from the email identifier, all parameters will remain unchanged unless specified. This endpoint may only be called by workspace administrators.")
        {
            _client = client;

            Arguments.Add(Email);
            Options.Add(XiApiKey);
            Options.Add(IsLocked);
            Options.Add(WorkspaceRole);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var email = parseResult.GetRequiredValue(Email);
            var isLocked = parseResult.GetRequiredValue(IsLocked);
            var workspaceRole = parseResult.GetRequiredValue(WorkspaceRole);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                email: email,
                isLocked: isLocked,
                workspaceRole: workspaceRole,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceMembersAsync(
                xiApiKey: xiApiKey,
                email: email,
                isLocked: isLocked,
                workspaceRole: workspaceRole,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}