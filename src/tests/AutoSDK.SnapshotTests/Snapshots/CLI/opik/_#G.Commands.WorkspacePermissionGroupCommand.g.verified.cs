//HintName: G.Commands.WorkspacePermissionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspacePermissionGroupCommand : global::System.CommandLine.Command
    {
        public WorkspacePermissionGroupCommand(
            WorkspacePermissionsGetWorkspaceUserPermissionsCommand command0)
            : base(
                name: "workspacepermission")
        {
            Subcommands.Add(command0);
        }
    }
}