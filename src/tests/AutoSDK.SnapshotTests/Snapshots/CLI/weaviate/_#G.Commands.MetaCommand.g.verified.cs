//HintName: G.Commands.MetaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaCommand : global::System.CommandLine.Command
    {
        public MetaCommand(
            MetaGetCommand command0)
            : base(
                name: "meta")
        {
            Subcommands.Add(command0);
        }
    }
}