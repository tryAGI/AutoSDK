//HintName: G.Commands.WorkspaceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspaceCommand : global::System.CommandLine.Command
    {
        public WorkspaceCommand(
            CreateWorkspaceUserAutoProvisioningCommand command0,
            GetWorkspaceGroupsSearchCommand command1,
            CreateWorkspaceGroupsByGroupIdMembersRemoveCommand command2,
            CreateWorkspaceGroupsByGroupIdMembersCommand command3,
            CreateWorkspaceInvitesAddCommand command4,
            CreateWorkspaceInvitesAddBulkCommand command5,
            DeleteWorkspaceInvitesCommand command6,
            CreateWorkspaceMembersCommand command7,
            DeleteWorkspaceMembersCommand command8,
            GetWorkspaceResourcesByResourceIdCommand command9,
            CreateWorkspaceResourcesByResourceIdShareCommand command10,
            CreateWorkspaceResourcesByResourceIdUnshareCommand command11,
            GetWorkspaceWebhooksCommand command12)
            : base(
                name: "workspace")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
        }
    }
}