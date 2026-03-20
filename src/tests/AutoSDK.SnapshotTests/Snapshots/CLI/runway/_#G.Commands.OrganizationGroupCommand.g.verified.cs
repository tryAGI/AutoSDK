//HintName: G.Commands.OrganizationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrganizationGroupCommand : global::System.CommandLine.Command
    {
        public OrganizationGroupCommand(
            OrganizationGetOrganizationCommand command0,
            OrganizationCreateOrganizationUsageCommand command1)
            : base(
                name: "organization")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}