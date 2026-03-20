//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ChatCommand command0,
            GenerateCommand command1,
            EmbedCommand command2,
            RerankCommand command3,
            ClassifyCommand command4,
            SummarizeCommand command5,
            TokenizeCommand command6,
            DetokenizeCommand command7,
            CheckAPIKeyCommand command8)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
        }
    }
}