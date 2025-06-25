//HintName: G.Commands.GithubCliLoginGithubCliLoginGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GithubCliLoginGithubCliLoginGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string loginId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> LoginId { get; } = new(
            name: "loginId")
        {
            Description = @"",
        };

        public GithubCliLoginGithubCliLoginGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "github",
            description: @"deepctl is calling this request waiting for auth token during login.
The token is stored in /github/callback")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(LoginId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var loginId = parseResult.GetRequiredValue(LoginId);

            Validate(
                parseResult: parseResult,
                loginId: loginId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GithubCliLoginGithubCliLoginGetAsync(
                loginId: loginId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}