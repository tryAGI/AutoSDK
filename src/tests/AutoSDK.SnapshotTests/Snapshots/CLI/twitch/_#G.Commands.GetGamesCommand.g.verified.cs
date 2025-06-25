//HintName: G.Commands.GetGamesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetGamesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the category or game to get. Include this parameter for each category or game you want to get. For example, `&id=1234&id=5678`. You may specify a maximum of 100 IDs. The endpoint ignores duplicate and invalid IDs or IDs that weren’t found.",
        };

        private new global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the category or game to get. The name must exactly match the category’s or game’s title. Include this parameter for each category or game you want to get. For example, `&name=foo&name=bar`. You may specify a maximum of 100 names. The endpoint ignores duplicate names and names that weren’t found.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IgdbId { get; } = new(
            name: "igdbId")
        {
            Description = @"The [IGDB](https://www.igdb.com/) ID of the game to get. Include this parameter for each game you want to get. For example, `&igdb_id=1234&igdb_id=5678`. You may specify a maximum of 100 IDs. The endpoint ignores duplicate and invalid IDs or IDs that weren’t found.",
        };
        public GetGamesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about specified categories or games.

You may get up to 100 categories or games by specifying their ID or name. You may specify all IDs, all names, or a combination of IDs and names. If you specify a combination of IDs and names, the total number of IDs and names must not exceed 100.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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