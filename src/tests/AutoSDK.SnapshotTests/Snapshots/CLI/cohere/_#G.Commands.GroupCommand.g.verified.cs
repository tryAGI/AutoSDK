//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ChatCommand command0,
            ChatAsStreamCommand command1,
            CheckAPIKeyCommand command2,
            ClassifyCommand command3,
            DetokenizeCommand command4,
            EmbedCommand command5,
            GenerateCommand command6,
            GenerateAsStreamCommand command7,
            RerankCommand command8,
            SummarizeCommand command9,
            TokenizeCommand command10)
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
        }
    }
}