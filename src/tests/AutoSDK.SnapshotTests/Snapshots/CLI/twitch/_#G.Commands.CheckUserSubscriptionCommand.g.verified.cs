//HintName: G.Commands.CheckUserSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckUserSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CheckUserSubscriptionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of a partner or affiliate broadcaster.",
        };

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user that you’re checking to see whether they subscribe to the broadcaster in _broadcaster\_id_. This ID must match the user ID in the access Token.",
        };

        public CheckUserSubscriptionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "check",
            description: @"Checks whether the user subscribes to the broadcaster’s channel.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:subscriptions** scope.

A Twitch extensions may use an app access token if the broadcaster has granted the **user:read:subscriptions** scope from within the Twitch Extensions manager.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(UserId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var userId = parseResult.GetRequiredValue(UserId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                userId: userId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Subscriptions.CheckUserSubscriptionAsync(
                broadcasterId: broadcasterId,
                userId: userId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}