//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ChatCommand command0,
            CheckAPIKeyCommand command1,
            ClassifyCommand command2,
            DetokenizeCommand command3,
            EmbedCommand command4,
            GenerateCommand command5,
            RerankCommand command6,
            SummarizeCommand command7,
            TokenizeCommand command8,
            Chatv2Command command9,
            Embedv2Command command10,
            Rerankv2Command command11)
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
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
        }
    }
}