//HintName: G.Commands.InspectScopedJwtV1ScopedJwtGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InspectScopedJwtV1ScopedJwtGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string jwtoken,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InspectScopedJWTOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Jwtoken { get; } = new(
            name: "jwtoken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public InspectScopedJwtV1ScopedJwtGetCommand(G.IApi client) : base(
            name: "inspect",
            description: @"")
        {
            _client = client;

            Arguments.Add(Jwtoken);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jwtoken = parseResult.GetRequiredValue(Jwtoken);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                jwtoken: jwtoken,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.InspectScopedJwtV1ScopedJwtGetAsync(
                jwtoken: jwtoken,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}