//HintName: G.Commands.CharityGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CharityGroupCommand : global::System.CommandLine.Command
    {
        public CharityGroupCommand(
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