//HintName: G.Commands.ClassificationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassificationCommand : global::System.CommandLine.Command
    {
        public ClassificationCommand(
            TrainV1TrainPostCommand command0,
            ClassifyV1ClassifyPostCommand command1)
            : base(
                name: "classification")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}