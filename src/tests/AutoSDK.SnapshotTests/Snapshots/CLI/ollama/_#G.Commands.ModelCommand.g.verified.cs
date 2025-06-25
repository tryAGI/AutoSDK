//HintName: G.Commands.ModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelCommand : global::System.CommandLine.Command
    {
        public ModelCommand(
            CreateModelCommand command0,
            ListModelsCommand command1,
            ListRunningModelsCommand command2,
            ShowModelInfoCommand command3,
            CopyModelCommand command4,
            DeleteModelCommand command5,
            PullModelCommand command6,
            PushModelCommand command7,
            CheckBlobCommand command8,
            CreateBlobCommand command9)
            : base(
                name: "model")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}