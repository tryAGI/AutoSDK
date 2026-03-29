//HintName: G.Commands.TranslationTranslateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslationTranslateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string text,
            string sourceLang,
            string targetLang,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranslationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for translation.
Default: solar-1-mini-translate-enko",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The text to translate.",
        };

        private global::System.CommandLine.Argument<string> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = @"Source language code (e.g., en, ko, ja).",
        };

        private global::System.CommandLine.Argument<string> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"Target language code (e.g., en, ko, ja).",
        };



        public TranslationTranslateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "translate",
            description: @"Translates text between languages using Solar translation models.
Supports English-Korean (solar-1-mini-translate-enko) and other language pairs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Text);
            Arguments.Add(SourceLang);
            Arguments.Add(TargetLang);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var text = parseResult.GetRequiredValue(Text);
            var sourceLang = parseResult.GetRequiredValue(SourceLang);
            var targetLang = parseResult.GetRequiredValue(TargetLang);

            Validate(
                parseResult: parseResult,
                model: model,
                text: text,
                sourceLang: sourceLang,
                targetLang: targetLang,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Translation.TranslateAsync(
                model: model,
                text: text,
                sourceLang: sourceLang,
                targetLang: targetLang,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}