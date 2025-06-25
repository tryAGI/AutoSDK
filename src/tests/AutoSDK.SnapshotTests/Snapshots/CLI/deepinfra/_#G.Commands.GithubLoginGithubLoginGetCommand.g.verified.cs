//HintName: G.Commands.GithubLoginGithubLoginGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GithubLoginGithubLoginGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? loginId,
            string? origin,
            string? deal,
            string? tiToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> LoginId { get; } = new(
            name: "loginId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Origin { get; } = new(
            name: "origin")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Deal { get; } = new(
            name: "deal")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> TiToken { get; } = new(
            name: "tiToken")
        {
            Description = @"",
        };
        public GithubLoginGithubLoginGetCommand(G.IApi client) : base(
            name: "github",
            description: @"Initiate github SSO login flow. Callback is /github/callback")
        {
            _client = client;

            Options.Add(LoginId);
            Options.Add(Origin);
            Options.Add(Deal);
            Options.Add(TiToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var loginId = parseResult.GetRequiredValue(LoginId);
            var origin = parseResult.GetRequiredValue(Origin);
            var deal = parseResult.GetRequiredValue(Deal);
            var tiToken = parseResult.GetRequiredValue(TiToken);

            Validate(
                parseResult: parseResult,
                loginId: loginId,
                origin: origin,
                deal: deal,
                tiToken: tiToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GithubLoginGithubLoginGetAsync(
                loginId: loginId,
                origin: origin,
                deal: deal,
                tiToken: tiToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}