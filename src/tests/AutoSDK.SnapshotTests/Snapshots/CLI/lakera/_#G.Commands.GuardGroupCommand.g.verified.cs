//HintName: G.Commands.GuardGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuardGroupCommand : global::System.CommandLine.Command
    {
        public GuardGroupCommand(
            GuardGuardCommand command0,
            GuardGuardResultsCommand command1)
            : base(
                name: "guard")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}