﻿//HintName: G.Commands.CreateWorkspaceResourcesByResourceIdUnshareCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceResourcesByResourceIdUnshareCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string resourceId,
            string? xiApiKey,
            global::G.WorkspaceResourceType resourceType,
            string? userEmail,
            string? groupId,
            string? workspaceApiKeyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResourceId { get; } = new(
            name: "resourceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.WorkspaceResourceType> ResourceType { get; } = new(
            name: "resourceType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> UserEmail { get; } = new(
            name: "userEmail")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> GroupId { get; } = new(
            name: "groupId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> WorkspaceApiKeyId { get; } = new(
            name: "workspaceApiKeyId")
        {
            Description = "",
        };
        public CreateWorkspaceResourcesByResourceIdUnshareCommand(G.IApi client) : base(
            name: "create",
            description: @"Removes any existing role on a workspace resource from a user, service account, group or workspace api key. To target a user or service account, pass only the user email. The user must be in your workspace. To target a group, pass only the group id. To target a workspace api key, pass the api key id. The resource will be unshared from the service account associated with the api key. You must have admin access to the resource to unshare it. You cannot remove permissions from the user who created the resource.")
        {
            _client = client;

            Arguments.Add(ResourceId);
            Arguments.Add(ResourceType);
            Options.Add(XiApiKey);
            Options.Add(UserEmail);
            Options.Add(GroupId);
            Options.Add(WorkspaceApiKeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var resourceId = parseResult.GetRequiredValue(ResourceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var resourceType = parseResult.GetRequiredValue(ResourceType);
            var userEmail = parseResult.GetRequiredValue(UserEmail);
            var groupId = parseResult.GetRequiredValue(GroupId);
            var workspaceApiKeyId = parseResult.GetRequiredValue(WorkspaceApiKeyId);

            Validate(
                parseResult: parseResult,
                resourceId: resourceId,
                xiApiKey: xiApiKey,
                resourceType: resourceType,
                userEmail: userEmail,
                groupId: groupId,
                workspaceApiKeyId: workspaceApiKeyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceResourcesByResourceIdUnshareAsync(
                resourceId: resourceId,
                xiApiKey: xiApiKey,
                resourceType: resourceType,
                userEmail: userEmail,
                groupId: groupId,
                workspaceApiKeyId: workspaceApiKeyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}