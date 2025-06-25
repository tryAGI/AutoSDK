//HintName: G.Commands.EntitlementCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EntitlementCommand : global::System.CommandLine.Command
    {
        public EntitlementCommand(
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