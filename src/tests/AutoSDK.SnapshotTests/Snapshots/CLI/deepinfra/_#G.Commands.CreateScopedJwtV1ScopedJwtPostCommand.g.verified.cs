//HintName: G.Commands.CreateScopedJwtV1ScopedJwtPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateScopedJwtV1ScopedJwtPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string apiTokenName,
            global::System.Collections.Generic.IList<string>? models,
            int? expiresDelta,
            int? expiresAt,
            double? spendingLimit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ScopedJWTOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApiTokenName { get; } = new(
            name: "apiTokenName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
            name: "models")
        {
            Description = @"allow inference only to the specified model names",
        };

        private global::System.CommandLine.Option<int?> ExpiresDelta { get; } = new(
            name: "expiresDelta")
        {
            Description = @"how many seconds in the future should the token be valid for",
        };

        private global::System.CommandLine.Option<int?> ExpiresAt { get; } = new(
            name: "expiresAt")
        {
            Description = @"unix timestamp when the token should expire",
        };

        private global::System.CommandLine.Option<double?> SpendingLimit { get; } = new(
            name: "spendingLimit")
        {
            Description = @"only allow spending that much USD until the token becomes invalid",
        };
        public CreateScopedJwtV1ScopedJwtPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApiTokenName);
            Options.Add(XiApiKey);
            Options.Add(Models);
            Options.Add(ExpiresDelta);
            Options.Add(ExpiresAt);
            Options.Add(SpendingLimit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var apiTokenName = parseResult.GetRequiredValue(ApiTokenName);
            var models = parseResult.GetRequiredValue(Models);
            var expiresDelta = parseResult.GetRequiredValue(ExpiresDelta);
            var expiresAt = parseResult.GetRequiredValue(ExpiresAt);
            var spendingLimit = parseResult.GetRequiredValue(SpendingLimit);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                apiTokenName: apiTokenName,
                models: models,
                expiresDelta: expiresDelta,
                expiresAt: expiresAt,
                spendingLimit: spendingLimit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateScopedJwtV1ScopedJwtPostAsync(
                xiApiKey: xiApiKey,
                apiTokenName: apiTokenName,
                models: models,
                expiresDelta: expiresDelta,
                expiresAt: expiresAt,
                spendingLimit: spendingLimit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}