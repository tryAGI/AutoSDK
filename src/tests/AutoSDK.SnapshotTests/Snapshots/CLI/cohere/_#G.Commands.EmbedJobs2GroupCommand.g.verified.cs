//HintName: G.Commands.EmbedJobs2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedJobs2GroupCommand : global::System.CommandLine.Command
    {
        public EmbedJobs2GroupCommand(
            EmbedJobs2CancelCommand command0,
            EmbedJobs2CreateCommand command1,
            EmbedJobs2GetCommand command2,
            EmbedJobs2ListCommand command3)
            : base(
                name: "embedjobs2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}