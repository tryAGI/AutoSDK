//HintName: G.Commands.PersonalizedVideoGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PersonalizedVideoGroupCommand : global::System.CommandLine.Command
    {
        public PersonalizedVideoGroupCommand(
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