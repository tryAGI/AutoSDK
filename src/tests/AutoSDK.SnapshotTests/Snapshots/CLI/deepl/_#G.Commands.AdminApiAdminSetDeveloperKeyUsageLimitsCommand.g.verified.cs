//HintName: G.Commands.AdminApiAdminSetDeveloperKeyUsageLimitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiAdminSetDeveloperKeyUsageLimitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string keyId,
            double? characters,
            double? speechToTextMilliseconds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> KeyId { get; } = new(
            name: "keyId")
        {
            Description = @"API key ID. Consists of two valid GUIDs separated by a colon.",
        };

        private global::System.CommandLine.Option<double?> Characters { get; } = new(
            name: "characters")
        {
            Description = @"Restricts the number of total characters (across text translation, document translation, and text improvement) that can be consumed by an API key in a one-month usage period.
Setting the limit to `0` means the API key will not be able to consume characters.
Setting the limit to `null` disables the limit, effectively allowing unlimited usage.",
        };

        private global::System.CommandLine.Option<double?> SpeechToTextMilliseconds { get; } = new(
            name: "speechToTextMilliseconds")
        {
            Description = @"Restricts the number of milliseconds of speech-to-text that can be consumed by an API key in a one-month usage period.
Setting the limit to `0` means the API key will not be able to consume speech-to-text milliseconds.
Setting the limit to `null` disables the limit, effectively allowing unlimited usage.",
        };


        public AdminApiAdminSetDeveloperKeyUsageLimitsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "admin",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(KeyId);
            Options.Add(Characters);
            Options.Add(SpeechToTextMilliseconds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var keyId = parseResult.GetRequiredValue(KeyId);
            var characters = parseResult.GetRequiredValue(Characters);
            var speechToTextMilliseconds = parseResult.GetRequiredValue(SpeechToTextMilliseconds);

            Validate(
                parseResult: parseResult,
                keyId: keyId,
                characters: characters,
                speechToTextMilliseconds: speechToTextMilliseconds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApi.AdminSetDeveloperKeyUsageLimitsAsync(
                keyId: keyId,
                characters: characters,
                speechToTextMilliseconds: speechToTextMilliseconds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}