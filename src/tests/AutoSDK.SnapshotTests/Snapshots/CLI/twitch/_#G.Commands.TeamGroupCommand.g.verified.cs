//HintName: G.Commands.TeamGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamGroupCommand : global::System.CommandLine.Command
    {
        public TeamGroupCommand(
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