//HintName: G.Commands.PollCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PollCommand : global::System.CommandLine.Command
    {
        public PollCommand(
            GetPollsCommand command0,
            CreatePollCommand command1,
            EndPollCommand command2)
            : base(
                name: "poll")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}