//HintName: G.Commands.WebhookGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhookGroupCommand : global::System.CommandLine.Command
    {
        public WebhookGroupCommand(
            WebhooksV1WebhookEndpointAddCommand command0,
            WebhooksV1WebhookEndpointDeleteCommand command1,
            WebhooksV1WebhookEndpointListCommand command2,
            WebhooksV1WebhookWebhookListCommand command3)
            : base(
                name: "webhook")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}