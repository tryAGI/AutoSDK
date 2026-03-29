//HintName: G.Commands.TenantGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TenantGroupCommand : global::System.CommandLine.Command
    {
        public TenantGroupCommand(
            TenantCreateTenantCommand command0,
            TenantGetTenantCommand command1,
            TenantUpdateTenantCommand command2)
            : base(
                name: "tenant")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}