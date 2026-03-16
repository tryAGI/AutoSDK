//HintName: G.Commands.OrganizationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrganizationGroupCommand : global::System.CommandLine.Command
    {
        public OrganizationGroupCommand(
            GetOrganizationCommand command0,
            CreateOrganizationUsageCommand command1)
            : base(
                name: "organization")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}