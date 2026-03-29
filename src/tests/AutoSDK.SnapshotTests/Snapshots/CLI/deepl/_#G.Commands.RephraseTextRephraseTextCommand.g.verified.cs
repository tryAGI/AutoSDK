//HintName: G.Commands.RephraseTextRephraseTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RephraseTextRephraseTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> text,
            global::G.TargetLanguageWrite? targetLang,
            global::G.WritingStyle? writingStyle,
            global::G.WritingTone? tone,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.RephraseTextResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Text { get; } = new(
            name: "text")
        {
            Description = @"Text to be improved. Only UTF-8-encoded plain text is supported. Improvements are returned in the same order as they are requested.",
        };

        private global::System.CommandLine.Option<global::G.TargetLanguageWrite?> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"The language for the text improvement. Options currently available:
 * `de` - German
 * `en` - English (unspecified variant, defaults to `en-US`)
 * `en-GB` - English (British)
 * `en-US` - English (American)
 * `es` - Spanish
 * `fr` - French
 * `it` - Italian
 * `pt` - Portuguese (unspecified variant, defaults to `pt-PT`)
 * `pt-BR` - Portuguese (Brazilian)
 * `pt-PT` - Portuguese (all Portuguese variants excluding Brazilian Portuguese)",
        };

        private global::System.CommandLine.Option<global::G.WritingStyle?> WritingStyle { get; } = new(
            name: "writingStyle")
        {
            Description = @"Specify a style to rephrase your text in a way that fits your audience and goals.
The `prefer_` prefix allows falling back to the default style if the language does not yet support styles.",
        };

        private global::System.CommandLine.Option<global::G.WritingTone?> Tone { get; } = new(
            name: "tone")
        {
            Description = @"Specify the desired tone for your text.
The `prefer_` prefix allows falling back to the default tone if the language does not yet support tones.",
        };


        public RephraseTextRephraseTextCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "rephrase",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);
            Options.Add(TargetLang);
            Options.Add(WritingStyle);
            Options.Add(Tone);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);
            var targetLang = parseResult.GetRequiredValue(TargetLang);
            var writingStyle = parseResult.GetRequiredValue(WritingStyle);
            var tone = parseResult.GetRequiredValue(Tone);

            Validate(
                parseResult: parseResult,
                text: text,
                targetLang: targetLang,
                writingStyle: writingStyle,
                tone: tone,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.RephraseText.RephraseTextAsync(
                text: text,
                targetLang: targetLang,
                writingStyle: writingStyle,
                tone: tone,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}