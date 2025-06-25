//HintName: G.Commands.CreateStreamMarkerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateStreamMarkerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateStreamMarkerResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };
        public CreateStreamMarkerCommand(G.IApi client) : base(
            name: "create",
            description: @"Adds a marker to a live stream. A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark, so they can return to that spot later to create video highlights (see Video Producer, Highlights in the Twitch UX).

You may not add markers:

* If the stream is not live
* If the stream has not enabled video on demand (VOD)
* If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)
* If the stream is a rerun of a past broadcast, including past premieres.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.")
        {
            _client = client;

            Arguments.Add(UserId);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                userId: userId,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Streams.CreateStreamMarkerAsync(
                userId: userId,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}