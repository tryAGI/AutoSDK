//HintName: G.Commands.GetStreamMarkersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetStreamMarkersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? userId,
            string? videoId,
            string? first,
            string? before,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetStreamMarkersResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> UserId { get; } = new(
            name: "userId")
        {
            Description = @"A user ID. The request returns the markers from this user’s most recent video. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.  
This parameter and the _video\_id_ query parameter are mutually exclusive.",
        };

        private global::System.CommandLine.Option<string?> VideoId { get; } = new(
            name: "videoId")
        {
            Description = @"A video on demand (VOD)/video ID. The request returns the markers from this VOD/video. The user in the access token must own the video or the user must be one of the broadcaster’s editors.  
This parameter and the _user\_id_ query parameter are mutually exclusive.",
        };

        private global::System.CommandLine.Option<string?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100 items per page. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"The cursor used to get the previous page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetStreamMarkersCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets a list of markers from the user’s most recent stream or from the specified VOD/video. A marker is an arbitrary point in a live stream that the broadcaster or editor marked, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:broadcast** or **channel:manage:broadcast** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(UserId);
            Options.Add(VideoId);
            Options.Add(First);
            Options.Add(Before);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var videoId = parseResult.GetRequiredValue(VideoId);
            var first = parseResult.GetRequiredValue(First);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                userId: userId,
                videoId: videoId,
                first: first,
                before: before,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Streams.GetStreamMarkersAsync(
                userId: userId,
                videoId: videoId,
                first: first,
                before: before,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}