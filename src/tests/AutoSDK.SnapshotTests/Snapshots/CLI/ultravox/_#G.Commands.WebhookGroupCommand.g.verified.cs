//HintName: G.Commands.WebhookGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhookGroupCommand : global::System.CommandLine.Command
    {
        public WebhookGroupCommand(
            WebhooksWebhooksCreateCommand command0,
            WebhooksWebhooksDestroyCommand command1,
            WebhooksWebhooksListCommand command2,
            WebhooksWebhooksPartialUpdateCommand command3,
            WebhooksWebhooksRetrieveCommand command4,
            WebhooksWebhooksUpdateCommand command5)
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