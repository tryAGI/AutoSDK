//HintName: G.Commands.OktaLoginOktaLoginGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OktaLoginOktaLoginGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string teamId,
            string? origin,
            string? loginId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Origin { get; } = new(
            name: "origin")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LoginId { get; } = new(
            name: "loginId")
        {
            Description = "",
        };
        public OktaLoginOktaLoginGetCommand(G.IApi client) : base(
            name: "okta",
            description: @"")
        {
            _client = client;

            Arguments.Add(TeamId);
            Options.Add(Origin);
            Options.Add(LoginId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var origin = parseResult.GetRequiredValue(Origin);
            var loginId = parseResult.GetRequiredValue(LoginId);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                origin: origin,
                loginId: loginId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OktaLoginOktaLoginGetAsync(
                teamId: teamId,
                origin: origin,
                loginId: loginId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}