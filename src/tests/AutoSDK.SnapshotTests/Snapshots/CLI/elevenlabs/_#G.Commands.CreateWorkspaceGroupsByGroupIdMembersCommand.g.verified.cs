//HintName: G.Commands.CreateWorkspaceGroupsByGroupIdMembersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceGroupsByGroupIdMembersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string groupId,
            string? xiApiKey,
            string email,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddWorkspaceGroupMemberResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GroupId { get; } = new(
            name: "groupId")
        {
            Description = "",
        };

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
        public CreateWorkspaceGroupsByGroupIdMembersCommand(G.IApi client) : base(
            name: "create",
            description: @"Adds a member of your workspace to the specified group. This endpoint may only be called by workspace administrators.")
        {
            _client = client;

            Arguments.Add(GroupId);
            Arguments.Add(Email);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var groupId = parseResult.GetRequiredValue(GroupId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var email = parseResult.GetRequiredValue(Email);

            Validate(
                parseResult: parseResult,
                groupId: groupId,
                xiApiKey: xiApiKey,
                email: email,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceGroupsByGroupIdMembersAsync(
                groupId: groupId,
                xiApiKey: xiApiKey,
                email: email,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}