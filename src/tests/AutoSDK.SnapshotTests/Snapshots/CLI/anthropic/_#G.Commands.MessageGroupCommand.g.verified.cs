//HintName: G.Commands.MessageGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageGroupCommand : global::System.CommandLine.Command
    {
        public MessageGroupCommand(
            MessagesPostCommand command0,
            MessagesCountTokensPostCommand command1,
            BetaMessagesPostCommand command2,
            BetaMessagesCountTokensPostCommand command3)
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