//HintName: G.Commands.ClassificationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassificationGroupCommand : global::System.CommandLine.Command
    {
        public ClassificationGroupCommand(
            ClassificationClassifyV1ClassifyPostCommand command0,
            ClassificationTrainV1TrainPostCommand command1)
            : base(
                name: "classification")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}