//HintName: G.Commands.GetGamesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetGamesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string>? id,
            global::System.Collections.Generic.IList<string>? name,
            global::System.Collections.Generic.IList<string>? igdbId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetGamesResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IgdbId { get; } = new(
            name: "igdbId")
        {
            Description = "",
        };
        public GetGamesCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets information about specified categories or games.

You may get up to 100 categories or games by specifying their ID or name. You may specify all IDs, all names, or a combination of IDs and names. If you specify a combination of IDs and names, the total number of IDs and names must not exceed 100.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;

            Options.Add(Id);
            Options.Add(Name);
            Options.Add(IgdbId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var igdbId = parseResult.GetRequiredValue(IgdbId);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                igdbId: igdbId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Games.GetGamesAsync(
                id: id,
                name: name,
                igdbId: igdbId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}