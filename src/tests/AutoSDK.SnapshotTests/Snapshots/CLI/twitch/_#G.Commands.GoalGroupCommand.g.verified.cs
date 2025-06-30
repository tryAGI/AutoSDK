//HintName: G.Commands.GoalGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GoalGroupCommand : global::System.CommandLine.Command
    {
        public GoalGroupCommand(
            GetCreatorGoalsCommand command0)
            : base(
                name: "goal")
        {
            Subcommands.Add(command0);
        }
    }
}