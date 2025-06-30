//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ModelsListCommand command0,
            ModelsGetCommand command1,
            BetaModelsListCommand command2,
            BetaModelsGetCommand command3)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}