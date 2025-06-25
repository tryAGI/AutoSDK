//HintName: G.Commands.ModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelCommand : global::System.CommandLine.Command
    {
        public ModelCommand(
            GetModelsCommand command0)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
        }
    }
}