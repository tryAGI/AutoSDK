//HintName: G.Commands.TeamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamCommand : global::System.CommandLine.Command
    {
        public TeamCommand(
            GetChannelTeamsCommand command0,
            GetTeamsCommand command1)
            : base(
                name: "team")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}