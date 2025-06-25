//HintName: G.Commands.DeleteVideosCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteVideosCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteVideosResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Id { get; } = new(
            name: "id")
        {
            Description = @"The list of videos to delete. To specify more than one video, include the _id_ parameter for each video to delete. For example, `id=1234&id=5678`. You can delete a maximum of 5 videos per request. Ignores invalid video IDs.  
If the user doesn’t have permission to delete one of the videos in the list, none of the videos are deleted.",
        };

        public DeleteVideosCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes one or more videos. You may delete past broadcasts, highlights, or uploads.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:videos** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Videos.DeleteVideosAsync(
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}