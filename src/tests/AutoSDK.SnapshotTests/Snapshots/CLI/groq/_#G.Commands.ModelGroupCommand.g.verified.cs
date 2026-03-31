//HintName: G.Commands.ModelGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelGroupCommand : global::System.CommandLine.Command
    {
        public ModelGroupCommand(
            ModelsDeleteModelCommand command0,
            ModelsListModelsCommand command1,
            ModelsRetrieveModelCommand command2)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}