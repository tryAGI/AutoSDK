//HintName: G.Commands.GetUserEmotesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUserEmotesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string? broadcasterId,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetUserEmotesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<string?> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"Returns all emotes available to the user within the chat owned by the specified broadcaster. This includes the Global and Subscriber Emotes the user has access to, as well as channel-only specific emotes such as Follower Emotes.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The Pagination object in the response contains the cursor’s value.",
        };
        public GetUserEmotesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"NEW Retrieves emotes available to the user across all channels.

__Authorization:__

* Requires a user access token that includes the **user:read:emotes** scope.
* Query parameter `user_id` must match the `user_id` in the user access token.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);
            Options.Add(BroadcasterId);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                userId: userId,
                broadcasterId: broadcasterId,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.GetUserEmotesAsync(
                userId: userId,
                broadcasterId: broadcasterId,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}