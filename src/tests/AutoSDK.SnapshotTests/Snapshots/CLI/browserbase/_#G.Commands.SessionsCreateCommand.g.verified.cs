//HintName: G.Commands.SessionsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SessionsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? projectId,
            string? extensionId,
            global::G.SessionsCreateRequestBrowserSettings? browserSettings,
            int? timeout,
            bool? keepAlive,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>? proxies,
            global::G.SessionsCreateRequestRegion? region,
            object? userMetadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.AllOf<global::G.Session, global::G.SessionsCreateResponse2> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.",
        };

        private global::System.CommandLine.Option<string?> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The uploaded Extension ID. See [Upload Extension](/reference/api/upload-an-extension).",
        };

        private global::System.CommandLine.Option<global::G.SessionsCreateRequestBrowserSettings?> BrowserSettings { get; } = new(
            name: "browserSettings")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Duration in seconds after which the session will automatically end. Defaults to the Project's `defaultTimeout`.",
        };

        private global::System.CommandLine.Option<bool?> KeepAlive { get; } = new(
            name: "keepAlive")
        {
            Description = @"Set to true to keep the session alive even after disconnections. Available on the Hobby Plan and above.",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BrowserbaseProxyConfig, global::G.ExternalProxyConfig, global::G.NoneProxyConfig>>, bool?>?> Proxies { get; } = new(
            name: "proxies")
        {
            Description = @"Proxy configuration. Can be true for default proxy, or an array of proxy configurations.",
        };

        private global::System.CommandLine.Option<global::G.SessionsCreateRequestRegion?> Region { get; } = new(
            name: "region")
        {
            Description = @"The region where the Session should run.",
        };

        private global::System.CommandLine.Option<object?> UserMetadata { get; } = new(
            name: "userMetadata")
        {
            Description = @"Arbitrary user metadata to attach to the session. To learn more about user metadata, see [User Metadata](/features/sessions#user-metadata).",
        };


        public SessionsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "sessions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(ExtensionId);
            Options.Add(BrowserSettings);
            Options.Add(Timeout);
            Options.Add(KeepAlive);
            Options.Add(Proxies);
            Options.Add(Region);
            Options.Add(UserMetadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var browserSettings = parseResult.GetRequiredValue(BrowserSettings);
            var timeout = parseResult.GetRequiredValue(Timeout);
            var keepAlive = parseResult.GetRequiredValue(KeepAlive);
            var proxies = parseResult.GetRequiredValue(Proxies);
            var region = parseResult.GetRequiredValue(Region);
            var userMetadata = parseResult.GetRequiredValue(UserMetadata);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                extensionId: extensionId,
                browserSettings: browserSettings,
                timeout: timeout,
                keepAlive: keepAlive,
                proxies: proxies,
                region: region,
                userMetadata: userMetadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SessionsCreateAsync(
                projectId: projectId,
                extensionId: extensionId,
                browserSettings: browserSettings,
                timeout: timeout,
                keepAlive: keepAlive,
                proxies: proxies,
                region: region,
                userMetadata: userMetadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}