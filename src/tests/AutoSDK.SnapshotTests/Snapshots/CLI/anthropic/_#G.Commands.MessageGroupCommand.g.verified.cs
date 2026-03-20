//HintName: G.Commands.MessageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageGroupCommand : global::System.CommandLine.Command
    {
        public MessageGroupCommand(
            MessagesBetaMessagesCountTokensPostCommand command0,
            MessagesBetaMessagesPostCommand command1,
            MessagesMessagesCountTokensPostCommand command2,
            MessagesMessagesPostCommand command3)
            : base(
                name: "message")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}