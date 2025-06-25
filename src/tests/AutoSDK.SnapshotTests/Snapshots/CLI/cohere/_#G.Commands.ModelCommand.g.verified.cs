//HintName: G.Commands.ModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelCommand : global::System.CommandLine.Command
    {
        public ModelCommand(
            ListModelsCommand command0,
            GetModelCommand command1)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}