//HintName: G.Commands.OllieStateGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OllieStateGroupCommand : global::System.CommandLine.Command
    {
        public OllieStateGroupCommand(
            OllieStateDeleteOllieStateCommand command0,
            OllieStateDownloadOllieStateCommand command1,
            OllieStateReplaceOllieStateCommand command2)
            : base(
                name: "olliestate")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}