//HintName: G.Commands.NodeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class NodeCommand : global::System.CommandLine.Command
    {
        public NodeCommand(
            NodesGetCommand command0,
            NodesGetClassCommand command1)
            : base(
                name: "node")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}