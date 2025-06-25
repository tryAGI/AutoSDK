//HintName: G.Commands.GetEventsubSubscriptionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEventsubSubscriptionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetEventsubSubscriptionsStatus? status,
            global::G.GetEventsubSubscriptionsType? type,
            string? userId,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetEventSubSubscriptionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.GetEventsubSubscriptionsStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"Filter subscriptions by its status. Possible values are:  
* enabled — The subscription is enabled.
* webhook\_callback\_verification\_pending — The subscription is pending verification of the specified callback URL.
* webhook\_callback\_verification\_failed — The specified callback URL failed verification.
* notification\_failures\_exceeded — The notification delivery failure rate was too high.
* authorization\_revoked — The authorization was revoked for one or more users specified in the **Condition** object.
* moderator\_removed — The moderator that authorized the subscription is no longer one of the broadcaster's moderators.
* user\_removed — One of the users specified in the **Condition** object was removed.
* version\_removed — The subscription to subscription type and version is no longer supported.
* beta\_maintenance — The subscription to the beta subscription type was removed due to maintenance.
* websocket\_disconnected — The client closed the connection.
* websocket\_failed\_ping\_pong — The client failed to respond to a ping message.
* websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).
* websocket\_connection\_unused — The client failed to subscribe to events within the required time.
* websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.
* websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.
* websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.",
        };

        private global::System.CommandLine.Option<global::G.GetEventsubSubscriptionsType?> Type { get; } = new(
            name: "type")
        {
            Description = @"Filter subscriptions by subscription type. For a list of subscription types, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types).",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"Filter subscriptions by user ID. The response contains subscriptions where this ID matches a user ID that you specified in the **Condition** object when you [created the subscription](https://dev.twitch.tv/docs/api/reference#create-eventsub-subscription).",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The `pagination` object in the response contains the cursor's value.",
        };
        public GetEventsubSubscriptionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of EventSub subscriptions that the client in the access token created.

__Authorization:__

If you use [Webhooks](https://dev.twitch.tv/docs/eventsub/handling-webhook-events) or [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.

If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.

__Request Query Parameters:__

Use the _status_, _type_, and _user\_id_ query parameters to filter the list of subscriptions that are returned. The filters are mutually exclusive; the request fails if you specify more than one filter.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Status);
            Options.Add(Type);
            Options.Add(UserId);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var status = parseResult.GetRequiredValue(Status);
            var type = parseResult.GetRequiredValue(Type);
            var userId = parseResult.GetRequiredValue(UserId);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                status: status,
                type: type,
                userId: userId,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.EventSub.GetEventsubSubscriptionsAsync(
                status: status,
                type: type,
                userId: userId,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}