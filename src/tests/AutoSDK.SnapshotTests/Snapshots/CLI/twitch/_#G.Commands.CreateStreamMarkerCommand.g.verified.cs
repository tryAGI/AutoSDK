//HintName: G.Commands.CreateStreamMarkerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateStreamMarkerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.",
        };
        public CreateStreamMarkerCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
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
            _serviceProvider = serviceProvider;

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