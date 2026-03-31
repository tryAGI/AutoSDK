//HintName: G.Commands.AdminGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminGroupCommand : global::System.CommandLine.Command
    {
        public AdminGroupCommand(
            AdminReingestAllStoresCommand command0)
            : base(
                name: "admin")
        {
            Subcommands.Add(command0);
        }
    }
}