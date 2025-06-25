//HintName: G.Commands.SingleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SingleCommand : global::System.CommandLine.Command
    {
        public SingleCommand(
            GetCurrentIpCommand command0,
            GetIpByIpCommand command1,
            GetCurrentHostnameCommand command2,
            GetHostnameByIpCommand command3,
            GetCurrentCityCommand command4,
            GetCityByIpCommand command5,
            GetCurrentRegionCommand command6,
            GetRegionByIpCommand command7,
            GetCurrentCountryCommand command8,
            GetCountryByIpCommand command9,
            GetCurrentLocationCommand command10,
            GetLocationByIpCommand command11,
            GetCurrentPostalCommand command12,
            GetPostalByIpCommand command13,
            GetCurrentTimezoneCommand command14,
            GetTimezoneByIpCommand command15,
            GetCurrentOrganizationCommand command16,
            GetOrganizationByIpCommand command17)
            : base(
                name: "single")
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
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
        }
    }
}