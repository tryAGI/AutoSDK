//HintName: G.Commands.EntitlementGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EntitlementGroupCommand : global::System.CommandLine.Command
    {
        public EntitlementGroupCommand(
            GetDropsEntitlementsCommand command0,
            UpdateDropsEntitlementsCommand command1)
            : base(
                name: "entitlement")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}