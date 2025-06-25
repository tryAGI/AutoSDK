//HintName: G.Commands.CreateEventsubSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEventsubSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateEventSubSubscriptionBodyType type,
            string version,
            object condition,
            global::G.CreateEventSubSubscriptionBodyTransport transport,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateEventSubSubscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.CreateEventSubSubscriptionBodyType> Type { get; } = new(
            name: "type")
        {
            Description = @"The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.",
        };

        private global::System.CommandLine.Argument<string> Version { get; } = new(
            name: "version")
        {
            Description = @"The version number that identifies the definition of the subscription type that you want the response to use.",
        };

        private global::System.CommandLine.Argument<object> Condition { get; } = new(
            name: "condition")
        {
            Description = @"A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.",
        };

        private global::System.CommandLine.Argument<global::G.CreateEventSubSubscriptionBodyTransport> Transport { get; } = new(
            name: "transport")
        {
            Description = @"The transport details that you want Twitch to use when sending you notifications.",
        };

        public CreateEventsubSubscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates an EventSub subscription.

__Authorization:__

If you use [webhooks to receive events](https://dev.twitch.tv/docs/eventsub/handling-webhook-events), the request must specify an app access token. The request will fail if you use a user access token. If the subscription type requires user authorization, the user must have granted your app (client ID) permissions to receive those events before you subscribe to them. For example, to subscribe to [channel.subscribe](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscribe) events, your app must get a user access token that includes the `channel:read:subscriptions` scope, which adds the required permission to your app access token’s client ID.

If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. If the subscription type requires user authorization, the token must include the required scope. However, if the subscription type doesn’t include user authorization, the token may include any scopes or no scopes.

If you use [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Type);
            Arguments.Add(Version);
            Arguments.Add(Condition);
            Arguments.Add(Transport);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var type = parseResult.GetRequiredValue(Type);
            var version = parseResult.GetRequiredValue(Version);
            var condition = parseResult.GetRequiredValue(Condition);
            var transport = parseResult.GetRequiredValue(Transport);

            Validate(
                parseResult: parseResult,
                type: type,
                version: version,
                condition: condition,
                transport: transport,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EventSub.CreateEventsubSubscriptionAsync(
                type: type,
                version: version,
                condition: condition,
                transport: transport,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}