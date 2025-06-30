//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelsListCommand command0)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
        }
    }
}