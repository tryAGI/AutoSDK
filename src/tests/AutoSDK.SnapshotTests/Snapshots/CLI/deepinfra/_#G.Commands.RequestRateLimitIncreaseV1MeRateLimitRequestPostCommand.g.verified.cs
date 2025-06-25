//HintName: G.Commands.RequestRateLimitIncreaseV1MeRateLimitRequestPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RequestRateLimitIncreaseV1MeRateLimitRequestPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            int rateLimit,
            string reason,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> RateLimit { get; } = new(
            name: "rateLimit")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Reason { get; } = new(
            name: "reason")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public RequestRateLimitIncreaseV1MeRateLimitRequestPostCommand(G.IApi client) : base(
            name: "request",
            description: @"")
        {
            _client = client;

            Arguments.Add(RateLimit);
            Arguments.Add(Reason);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var rateLimit = parseResult.GetRequiredValue(RateLimit);
            var reason = parseResult.GetRequiredValue(Reason);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                rateLimit: rateLimit,
                reason: reason,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RequestRateLimitIncreaseV1MeRateLimitRequestPostAsync(
                xiApiKey: xiApiKey,
                rateLimit: rateLimit,
                reason: reason,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}