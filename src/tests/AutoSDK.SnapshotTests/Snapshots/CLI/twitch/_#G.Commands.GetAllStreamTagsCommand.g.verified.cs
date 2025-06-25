//HintName: G.Commands.GetAllStreamTagsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetAllStreamTagsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? tagId,
            int? first,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetAllStreamTagsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagId { get; } = new(
            name: "tagId")
        {
            Description = @"The ID of the tag to get. Used to filter the list of tags. To specify more than one tag, include the _tag\_id_ parameter for each tag to get. For example, `tag_id=1234&tag_id=5678`. The maximum number of IDs you may specify is 100\. Ignores invalid IDs but not duplicate IDs.",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = @"The maximum number of items to return per page in the response. The minimum page size is 1 item per page and the maximum is 100\. The default is 20.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The **Pagination** object in the response contains the cursor’s value. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)",
        };
        public GetAllStreamTagsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"**IMPORTANT** Twitch is moving from Twitch-defined tags to channel-defined tags. **IMPORTANT** As of February 28, 2023, this endpoint returns an empty array. On July 13, 2023, it will return a 410 response.

Gets a list of all stream tags that Twitch defines. The broadcaster may apply any of these to their channel except automatic tags. For an online list of the possible tags, see [List of All Tags](https://www.twitch.tv/directory/all/tags).

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(TagId);
            Options.Add(First);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var tagId = parseResult.GetRequiredValue(TagId);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                tagId: tagId,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tags.GetAllStreamTagsAsync(
                tagId: tagId,
                first: first,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}