//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelsGetCommand command0,
            ModelsListCommand command1)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}