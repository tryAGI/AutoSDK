//HintName: G.Commands.GameCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GameCommand : global::System.CommandLine.Command
    {
        public GameCommand(
            GetTopGamesCommand command0,
            GetGamesCommand command1)
            : base(
                name: "game")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}