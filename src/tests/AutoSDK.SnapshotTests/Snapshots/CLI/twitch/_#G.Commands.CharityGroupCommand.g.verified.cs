//HintName: G.Commands.CharityGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CharityGroupCommand : global::System.CommandLine.Command
    {
        public CharityGroupCommand(
            CharityGetCharityCampaignCommand command0,
            CharityGetCharityCampaignDonationsCommand command1)
            : base(
                name: "charity")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}