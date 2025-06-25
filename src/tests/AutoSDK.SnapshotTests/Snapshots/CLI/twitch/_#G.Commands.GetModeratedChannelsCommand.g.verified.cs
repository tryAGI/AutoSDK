//HintName: G.Commands.GetModeratedChannelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetModeratedChannelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string? after,
            int? first,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetModeratedChannelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A user’s ID. Returns the list of channels that this user has moderator privileges in. This ID must match the user ID in the user OAuth token",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The Pagination object in the response contains the cursor’s value.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response.  
Minimum page size is 1 item per page and the maximum is 100\. The default is 20.",
        };
        public GetModeratedChannelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of channels that the specified user has moderator privileges in.

__Authorization:__

* Query parameter `user_id` must match the user ID in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)
* Requires OAuth Scope: `user:read:moderated_channels`")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);
            Options.Add(After);
            Options.Add(First);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var after = parseResult.GetRequiredValue(After);
            var first = parseResult.GetRequiredValue(First);

            Validate(
                parseResult: parseResult,
                userId: userId,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.GetModeratedChannelsAsync(
                userId: userId,
                after: after,
                first: first,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}