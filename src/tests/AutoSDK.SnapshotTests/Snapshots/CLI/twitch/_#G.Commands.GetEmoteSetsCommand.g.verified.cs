//HintName: G.Commands.GetEmoteSetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEmoteSetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> emoteSetId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetEmoteSetsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> EmoteSetId { get; } = new(
            name: "emoteSetId")
        {
            Description = @"",
        };

        public GetEmoteSetsCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets emotes for one or more specified emote sets.

An emote set groups emotes that have a similar context. For example, Twitch places all the subscriber emotes that a broadcaster uploads for their channel in the same emote set.

[Learn More](https://dev.twitch.tv/docs/irc/emotes)

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

            Arguments.Add(EmoteSetId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var emoteSetId = parseResult.GetRequiredValue(EmoteSetId);

            Validate(
                parseResult: parseResult,
                emoteSetId: emoteSetId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.GetEmoteSetsAsync(
                emoteSetId: emoteSetId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}