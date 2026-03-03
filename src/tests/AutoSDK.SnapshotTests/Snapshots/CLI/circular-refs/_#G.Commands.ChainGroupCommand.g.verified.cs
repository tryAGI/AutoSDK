//HintName: G.Commands.ChainGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChainGroupCommand : global::System.CommandLine.Command
    {
        public ChainGroupCommand(
            GetChainCommand command0)
            : base(
                name: "chain")
        {
            Subcommands.Add(command0);
        }
    }
}