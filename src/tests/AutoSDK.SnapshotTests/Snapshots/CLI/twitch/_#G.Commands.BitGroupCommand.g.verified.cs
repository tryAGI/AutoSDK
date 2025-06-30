//HintName: G.Commands.BitGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BitGroupCommand : global::System.CommandLine.Command
    {
        public BitGroupCommand(
            GetBitsLeaderboardCommand command0,
            GetCheermotesCommand command1,
            GetExtensionTransactionsCommand command2)
            : base(
                name: "bit")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}