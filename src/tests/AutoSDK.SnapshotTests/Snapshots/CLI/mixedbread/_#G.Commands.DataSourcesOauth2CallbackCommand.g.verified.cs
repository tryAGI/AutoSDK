//HintName: G.Commands.DataSourcesOauth2CallbackCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DataSourcesOauth2CallbackCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string state,
            string code,
            string? error,
            string? errorDescription,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> State { get; } = new(
            name: "state")
        {
            Description = @"OAuth2 state parameter for CSRF protection",
        };

        private global::System.CommandLine.Argument<string> Code { get; } = new(
            name: "code")
        {
            Description = @"Authorization code from OAuth2 provider",
        };

        private global::System.CommandLine.Option<string?> Error { get; } = new(
            name: "error")
        {
            Description = @"OAuth2 error code if authorization failed",
        };

        private global::System.CommandLine.Option<string?> ErrorDescription { get; } = new(
            name: "errorDescription")
        {
            Description = @"Human-readable error description",
        };


        public DataSourcesOauth2CallbackCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "oauth2callback",
            description: @"OAuth2 callback endpoint for completing data source authorization.

This endpoint is called by OAuth2 providers after user authorization.
It exchanges the authorization code for access tokens and stores them
securely for the data source.

Args:
    state: OAuth2 state parameter used for CSRF protection
    code: Authorization code from the OAuth2 provider
    error: OAuth2 error code if authorization was denied or failed
    error_description: Human-readable description of the error

Returns:
    Redirect to the data source details page on success

Raises:
    OAuth2TokenExchangeError: When OAuth2 provider returns an error
    InvalidStateError: When state parameter is invalid or expired")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(State);
            Arguments.Add(Code);
            Options.Add(Error);
            Options.Add(ErrorDescription);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var state = parseResult.GetRequiredValue(State);
            var code = parseResult.GetRequiredValue(Code);
            var error = parseResult.GetRequiredValue(Error);
            var errorDescription = parseResult.GetRequiredValue(ErrorDescription);

            Validate(
                parseResult: parseResult,
                state: state,
                code: code,
                error: error,
                errorDescription: errorDescription,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.DataSources.Oauth2CallbackAsync(
                state: state,
                code: code,
                error: error,
                errorDescription: errorDescription,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}