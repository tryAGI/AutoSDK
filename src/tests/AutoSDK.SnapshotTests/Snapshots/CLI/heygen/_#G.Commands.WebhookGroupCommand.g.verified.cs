//HintName: G.Commands.WebhookGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WebhookGroupCommand : global::System.CommandLine.Command
    {
        public WebhookGroupCommand(
            V1WebhookWebhookListCommand command0,
            V1WebhookEndpointAddCommand command1,
            V1WebhookEndpointDeleteCommand command2,
            V1WebhookEndpointListCommand command3)
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