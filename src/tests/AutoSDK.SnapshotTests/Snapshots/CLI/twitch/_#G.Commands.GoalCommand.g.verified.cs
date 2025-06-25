//HintName: G.Commands.GoalCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GoalCommand : global::System.CommandLine.Command
    {
        public GoalCommand(
            GetCreatorGoalsCommand command0)
            : base(
                name: "goal")
        {
            Subcommands.Add(command0);
        }
    }
}