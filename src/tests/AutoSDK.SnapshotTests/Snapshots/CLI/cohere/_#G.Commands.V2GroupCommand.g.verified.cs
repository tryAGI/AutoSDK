//HintName: G.Commands.V2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class V2GroupCommand : global::System.CommandLine.Command
    {
        public V2GroupCommand(
            V2Chat2Command command0,
            V2Embed2Command command1,
            V2Rerank2Command command2)
            : base(
                name: "v2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}