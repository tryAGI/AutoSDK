//HintName: G.Commands.PersonalizedVideoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PersonalizedVideoCommand : global::System.CommandLine.Command
    {
        public PersonalizedVideoCommand(
            PersonalizedVideoAddContactCommand command0,
            PersonalizedVideoAudienceDetailCommand command1,
            PersonalizedVideoProjectDetailCommand command2)
            : base(
                name: "personalizedvideo")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}