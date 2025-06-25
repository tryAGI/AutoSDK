//HintName: G.Commands.TeamSetDisplayNameV1MeTeamDisplayNamePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamSetDisplayNameV1MeTeamDisplayNamePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string displayName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public TeamSetDisplayNameV1MeTeamDisplayNamePostCommand(G.IApi client) : base(
            name: "team",
            description: @"")
        {
            _client = client;

            Arguments.Add(DisplayName);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var displayName = parseResult.GetRequiredValue(DisplayName);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                displayName: displayName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TeamSetDisplayNameV1MeTeamDisplayNamePostAsync(
                xiApiKey: xiApiKey,
                displayName: displayName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}