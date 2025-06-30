//HintName: G.Commands.ClassificationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassificationGroupCommand : global::System.CommandLine.Command
    {
        public ClassificationGroupCommand(
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