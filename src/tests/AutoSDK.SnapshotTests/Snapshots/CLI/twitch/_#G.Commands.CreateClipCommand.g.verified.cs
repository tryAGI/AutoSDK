//HintName: G.Commands.CreateClipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateClipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            bool? hasDelay,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateClipResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasDelay { get; } = new(
            name: "hasDelay")
        {
            Description = "",
        };
        public CreateClipCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a clip from the broadcaster’s stream.

This API captures up to 90 seconds of the broadcaster’s stream. The 90 seconds spans the point in the stream from when you called the API. For example, if you call the API at the 4:00 minute mark, the API captures from approximately the 3:35 mark to approximately the 4:05 minute mark. Twitch tries its best to capture 90 seconds of the stream, but the actual length may be less. This may occur if you begin capturing the clip near the beginning or end of the stream.

By default, Twitch publishes up to the last 30 seconds of the 90 seconds window and provides a default title for the clip. To specify the title and the portion of the 90 seconds window that’s used for the clip, use the URL in the response’s `edit_url` field. You can specify a clip that’s from 5 seconds to 60 seconds in length. The URL is valid for up to 24 hours or until the clip is published, whichever comes first.

Creating a clip is an asynchronous process that can take a short amount of time to complete. To determine whether the clip was successfully created, call [Get Clips](https://dev.twitch.tv/docs/api/reference#get-clips) using the clip ID that this request returned. If Get Clips returns the clip, the clip was successfully created. If after 15 seconds Get Clips hasn’t returned the clip, assume it failed.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **clips:edit** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Options.Add(HasDelay);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var hasDelay = parseResult.GetRequiredValue(HasDelay);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                hasDelay: hasDelay,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Clips.CreateClipAsync(
                broadcasterId: broadcasterId,
                hasDelay: hasDelay,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}