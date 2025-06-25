//HintName: G.Commands.GetContentClassificationLabelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetContentClassificationLabelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? locale,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetContentClassificationLabelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Locale { get; } = new(
            name: "locale")
        {
            Description = @"Locale for the Content Classification Labels. You may specify a maximum of 1 locale. Default: `“en-US”`  
Supported locales: `""bg-BG"", ""cs-CZ"", ""da-DK"", ""da-DK"", ""de-DE"", ""el-GR"", ""en-GB"", ""en-US"", ""es-ES"", ""es-MX"", ""fi-FI"", ""fr-FR"", ""hu-HU"", ""it-IT"", ""ja-JP"", ""ko-KR"", ""nl-NL"", ""no-NO"", ""pl-PL"", ""pt-BT"", ""pt-PT"", ""ro-RO"", ""ru-RU"", ""sk-SK"", ""sv-SE"", ""th-TH"", ""tr-TR"", ""vi-VN"", ""zh-CN"", ""zh-TW""`",
        };
        public GetContentClassificationLabelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about Twitch content classification labels.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Locale);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var locale = parseResult.GetRequiredValue(Locale);

            Validate(
                parseResult: parseResult,
                locale: locale,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CCLs.GetContentClassificationLabelsAsync(
                locale: locale,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}