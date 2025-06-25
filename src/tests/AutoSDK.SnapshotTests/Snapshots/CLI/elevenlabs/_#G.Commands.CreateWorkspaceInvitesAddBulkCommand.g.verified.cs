//HintName: G.Commands.CreateWorkspaceInvitesAddBulkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceInvitesAddBulkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string>? groupIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddWorkspaceInviteResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Emails { get; } = new(
            name: "emails")
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
        public CreateWorkspaceInvitesAddBulkCommand(G.IApi client) : base(
            name: "create",
            description: @"Sends email invitations to join your workspace to the provided emails. Requires all email addresses to be part of a verified domain. If the users don't have an account they will be prompted to create one. If the users accept these invites they will be added as users to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators.")
        {
            _client = client;

            Arguments.Add(Emails);
            Options.Add(XiApiKey);
            Options.Add(GroupIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var emails = parseResult.GetRequiredValue(Emails);
            var groupIds = parseResult.GetRequiredValue(GroupIds);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                emails: emails,
                groupIds: groupIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceInvitesAddBulkAsync(
                xiApiKey: xiApiKey,
                emails: emails,
                groupIds: groupIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}