//HintName: G.Commands.GetEventsubSubscriptionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEventsubSubscriptionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetEventsubSubscriptionsType?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };
        public GetEventsubSubscriptionsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets a list of EventSub subscriptions that the client in the access token created.

__Authorization:__

If you use [Webhooks](https://dev.twitch.tv/docs/eventsub/handling-webhook-events) or [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.

If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.

__Request Query Parameters:__

Use the _status_, _type_, and _user\_id_ query parameters to filter the list of subscriptions that are returned. The filters are mutually exclusive; the request fails if you specify more than one filter.")
        {
            _client = client;

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