//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ChatCommand command0,
            Chatv2Command command1,
            GenerateCommand command2,
            EmbedCommand command3,
            Embedv2Command command4,
            RerankCommand command5,
            Rerankv2Command command6,
            ClassifyCommand command7,
            SummarizeCommand command8,
            TokenizeCommand command9,
            DetokenizeCommand command10,
            CheckAPIKeyCommand command11)
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