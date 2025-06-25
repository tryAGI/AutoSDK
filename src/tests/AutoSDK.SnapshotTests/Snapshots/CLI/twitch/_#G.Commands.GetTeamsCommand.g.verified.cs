//HintName: G.Commands.GetTeamsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTeamsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            string? id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetTeamsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"The name of the team to get. This parameter and the _id_ parameter are mutually exclusive; you must specify the team’s name or ID but not both.",
        };

        private global::System.CommandLine.Option<string?> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the team to get. This parameter and the _name_ parameter are mutually exclusive; you must specify the team’s name or ID but not both.",
        };
        public GetTeamsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about the specified Twitch team. [Read More](https://help.twitch.tv/s/article/twitch-teams)

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Name);
            Options.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                name: name,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.GetTeamsAsync(
                name: name,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}