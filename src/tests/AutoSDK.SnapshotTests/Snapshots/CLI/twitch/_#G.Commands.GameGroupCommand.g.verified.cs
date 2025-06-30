//HintName: G.Commands.GameGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GameGroupCommand : global::System.CommandLine.Command
    {
        public GameGroupCommand(
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