//HintName: G.Commands.MessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessageCommand : global::System.CommandLine.Command
    {
        public MessageCommand(
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