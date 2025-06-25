//HintName: G.Commands.AppsUpdateWebhookConfigForAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsUpdateWebhookConfigForAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? url,
            string? contentType,
            string? secret,
            global::G.WebhookConfigInsecureSsl? insecureSsl,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WebhookConfig response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ContentType { get; } = new(
            name: "contentType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Secret { get; } = new(
            name: "secret")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.WebhookConfigInsecureSsl?> InsecureSsl { get; } = new(
            name: "insecureSsl")
        {
            Description = "",
        };
        public AppsUpdateWebhookConfigForAppCommand(G.IApi client) : base(
            name: "apps",
            description: @"Updates the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see ""[Creating a GitHub App](/developers/apps/creating-a-github-app).""

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

            Options.Add(Url);
            Options.Add(ContentType);
            Options.Add(Secret);
            Options.Add(InsecureSsl);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var contentType = parseResult.GetRequiredValue(ContentType);
            var secret = parseResult.GetRequiredValue(Secret);
            var insecureSsl = parseResult.GetRequiredValue(InsecureSsl);

            Validate(
                parseResult: parseResult,
                url: url,
                contentType: contentType,
                secret: secret,
                insecureSsl: insecureSsl,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsUpdateWebhookConfigForAppAsync(
                url: url,
                contentType: contentType,
                secret: secret,
                insecureSsl: insecureSsl,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}