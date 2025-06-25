//HintName: G.Commands.CharityCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CharityCommand : global::System.CommandLine.Command
    {
        public CharityCommand(
            GetCharityCampaignCommand command0,
            GetCharityCampaignDonationsCommand command1)
            : base(
                name: "charity")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}