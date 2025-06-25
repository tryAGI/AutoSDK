//HintName: G.Commands.EmbedJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EmbedJobCommand : global::System.CommandLine.Command
    {
        public EmbedJobCommand(
            ListEmbedJobsCommand command0,
            CreateEmbedJobCommand command1,
            GetEmbedJobCommand command2,
            CancelEmbedJobCommand command3)
            : base(
                name: "embedjob")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}