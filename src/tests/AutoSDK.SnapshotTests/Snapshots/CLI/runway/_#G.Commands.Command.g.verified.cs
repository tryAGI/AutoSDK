//HintName: G.Commands.Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Command : global::System.CommandLine.Command
    {
        public Command(
            CreateVideoFromImageCommand command0,
            GetTaskDetailCommand command1,
            CancelOrDeleteTaskCommand command2)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}