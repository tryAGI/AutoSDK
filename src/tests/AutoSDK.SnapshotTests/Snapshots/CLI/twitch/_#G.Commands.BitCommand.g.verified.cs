//HintName: G.Commands.BitCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BitCommand : global::System.CommandLine.Command
    {
        public BitCommand(
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