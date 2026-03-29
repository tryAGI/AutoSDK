//HintName: G.Commands.RoleOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RoleOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public RoleOperationsV2GroupCommand(
            RoleOperationsV2CreateVectordbRolesCreateCommand command0,
            RoleOperationsV2CreateVectordbRolesDescribeCommand command1,
            RoleOperationsV2CreateVectordbRolesDropCommand command2,
            RoleOperationsV2CreateVectordbRolesGrantPrivilegeCommand command3,
            RoleOperationsV2CreateVectordbRolesListCommand command4,
            RoleOperationsV2CreateVectordbRolesRevokePrivilegeCommand command5)
            : base(
                name: "roleoperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}