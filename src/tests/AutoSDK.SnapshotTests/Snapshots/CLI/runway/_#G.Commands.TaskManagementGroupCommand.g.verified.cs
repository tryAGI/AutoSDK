//HintName: G.Commands.TaskManagementGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TaskManagementGroupCommand : global::System.CommandLine.Command
    {
        public TaskManagementGroupCommand(
            GetTasksByIdCommand command0,
            DeleteTasksByIdCommand command1)
            : base(
                name: "taskmanagement")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}