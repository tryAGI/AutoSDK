//HintName: G.Commands.WebhookGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhookGroupCommand : global::System.CommandLine.Command
    {
        public WebhookGroupCommand(
            WebhooksWebhooksListCommand command0,
            WebhooksWebhooksCreateCommand command1,
            WebhooksWebhooksRetrieveCommand command2,
            WebhooksWebhooksUpdateCommand command3,
            WebhooksWebhooksPartialUpdateCommand command4,
            WebhooksWebhooksDestroyCommand command5)
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