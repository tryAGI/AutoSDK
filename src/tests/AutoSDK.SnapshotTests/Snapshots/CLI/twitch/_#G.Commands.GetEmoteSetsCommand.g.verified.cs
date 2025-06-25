//HintName: G.Commands.GetEmoteSetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetEmoteSetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"An ID that identifies the emote set to get. Include this parameter for each emote set you want to get. For example, `emote_set_id=1234&emote_set_id=5678`. You may specify a maximum of 25 IDs. The response contains only the IDs that were found and ignores duplicate IDs.  
To get emote set IDs, use the [Get Channel Emotes](https://dev.twitch.tv/docs/api/reference#get-channel-emotes) API.",
        };

        public GetEmoteSetsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets emotes for one or more specified emote sets.

An emote set groups emotes that have a similar context. For example, Twitch places all the subscriber emotes that a broadcaster uploads for their channel in the same emote set.

[Learn More](https://dev.twitch.tv/docs/irc/emotes)

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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