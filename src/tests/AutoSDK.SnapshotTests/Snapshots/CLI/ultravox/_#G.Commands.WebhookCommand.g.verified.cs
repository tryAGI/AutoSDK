//HintName: G.Commands.WebhookCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhookCommand : global::System.CommandLine.Command
    {
        public WebhookCommand(
            WebhooksListCommand command0,
            WebhooksCreateCommand command1,
            WebhooksRetrieveCommand command2,
            WebhooksUpdateCommand command3,
            WebhooksPartialUpdateCommand command4,
            WebhooksDestroyCommand command5)
            : base(
                name: "webhook")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}