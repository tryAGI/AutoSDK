//HintName: G.Commands.TtGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TtGroupCommand : global::System.CommandLine.Command
    {
        public TtGroupCommand(
            TtsTtsBytesCommand command0,
            TtsTtsSseCommand command1)
            : base(
                name: "tt")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}