//HintName: G.Commands.BitGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BitGroupCommand : global::System.CommandLine.Command
    {
        public BitGroupCommand(
            BitsGetBitsLeaderboardCommand command0,
            BitsGetCheermotesCommand command1,
            BitsGetExtensionTransactionsCommand command2)
            : base(
                name: "bit")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}