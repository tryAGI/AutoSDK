//HintName: G.Commands.AuthAuthAccessTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AuthAuthAccessTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AuthAccessTokenCartesiaVersion cartesiaVersion,
            global::G.TokenGrant? grants,
            int? expiresIn,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TokenResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AuthAccessTokenCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<global::G.TokenGrant?> Grants { get; } = new(
            name: "grants")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> ExpiresIn { get; } = new(
            name: "expiresIn")
        {
            Description = @"The number of seconds the token will be valid for since the time of generation. The maximum is 1 hour (3600 seconds).",
        };


        public AuthAuthAccessTokenCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "auth",
            description: @"Generates a new Access Token for the client. These tokens are short-lived and should be used to make requests to the API from authenticated clients.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(Grants);
            Options.Add(ExpiresIn);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var grants = parseResult.GetRequiredValue(Grants);
            var expiresIn = parseResult.GetRequiredValue(ExpiresIn);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                grants: grants,
                expiresIn: expiresIn,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Auth.AuthAccessTokenAsync(
                cartesiaVersion: cartesiaVersion,
                grants: grants,
                expiresIn: expiresIn,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}