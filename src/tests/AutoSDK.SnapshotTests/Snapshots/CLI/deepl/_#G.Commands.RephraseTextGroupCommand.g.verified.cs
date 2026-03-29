//HintName: G.Commands.RephraseTextGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RephraseTextGroupCommand : global::System.CommandLine.Command
    {
        public RephraseTextGroupCommand(
            RephraseTextRephraseTextCommand command0)
            : base(
                name: "rephrasetext")
        {
            Subcommands.Add(command0);
        }
    }
}