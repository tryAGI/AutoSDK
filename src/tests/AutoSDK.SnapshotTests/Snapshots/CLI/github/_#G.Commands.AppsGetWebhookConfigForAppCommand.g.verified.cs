//HintName: G.Commands.AppsGetWebhookConfigForAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsGetWebhookConfigForAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WebhookConfig response,
            global::System.Threading.CancellationToken cancellationToken);


        public AppsGetWebhookConfigForAppCommand(G.IApi client) : base(
            name: "apps",
            description: @"Returns the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see ""[Creating a GitHub App](/developers/apps/creating-a-github-app).""

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsGetWebhookConfigForAppAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}