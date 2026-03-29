//HintName: G.Commands.VoiceAPIGetVoiceStreamingUrlCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class VoiceAPIGetVoiceStreamingUrlCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.VoiceMediaContentType sourceMediaContentType,
            global::G.VoiceSourceLanguage? sourceLanguage,
            global::G.VoiceSourceLanguageMode? sourceLanguageMode,
            global::System.Collections.Generic.IList<string>? targetLanguages,
            string? glossaryId,
            global::G.VoiceFormality? formality,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.VoiceStreamingResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.VoiceMediaContentType> SourceMediaContentType { get; } = new(
            name: "sourceMediaContentType")
        {
            Description = @"The audio format for streaming. Specifies container, codec, and encoding parameters.
Supported formats include PCM (recommended), OPUS (recommended for low bandwidth), FLAC, MP3, and AAC.
PCM formats require explicit sample rate. Mono audio only.",
        };

        private global::System.CommandLine.Option<global::G.VoiceSourceLanguage?> SourceLanguage { get; } = new(
            name: "sourceLanguage")
        {
            Description = @"Source language of the audio stream. Must be one of the supported Voice API source languages.
Language identifier must comply with IETF BCP 47 language tags.",
        };

        private global::System.CommandLine.Option<global::G.VoiceSourceLanguageMode?> SourceLanguageMode { get; } = new(
            name: "sourceLanguageMode")
        {
            Description = @"Controls how the source_language value is used.
- `auto`: Treats source language as a hint; server can override
- `fixed`: Treats source language as mandatory; server must use this language",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TargetLanguages { get; } = new(
            name: "targetLanguages")
        {
            Description = @"List of target languages for translation. The stream will emit translations for each language.
Maximum 5 target languages per stream. Language identifiers must comply with IETF BCP 47.",
        };

        private global::System.CommandLine.Option<string?> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to a glossary.",
        };

        private global::System.CommandLine.Option<global::G.VoiceFormality?> Formality { get; } = new(
            name: "formality")
        {
            Description = @"Sets whether the translated text should lean towards formal or informal language.
Possible options are:
  * `default` - use the default formality for the target language
  * `formal`/`more` - for a more formal language
  * `informal`/`less` - for a more informal language",
        };


        public VoiceAPIGetVoiceStreamingUrlCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(SourceMediaContentType);
            Options.Add(SourceLanguage);
            Options.Add(SourceLanguageMode);
            Options.Add(TargetLanguages);
            Options.Add(GlossaryId);
            Options.Add(Formality);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sourceMediaContentType = parseResult.GetRequiredValue(SourceMediaContentType);
            var sourceLanguage = parseResult.GetRequiredValue(SourceLanguage);
            var sourceLanguageMode = parseResult.GetRequiredValue(SourceLanguageMode);
            var targetLanguages = parseResult.GetRequiredValue(TargetLanguages);
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);
            var formality = parseResult.GetRequiredValue(Formality);

            Validate(
                parseResult: parseResult,
                sourceMediaContentType: sourceMediaContentType,
                sourceLanguage: sourceLanguage,
                sourceLanguageMode: sourceLanguageMode,
                targetLanguages: targetLanguages,
                glossaryId: glossaryId,
                formality: formality,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VoiceAPI.GetVoiceStreamingUrlAsync(
                sourceMediaContentType: sourceMediaContentType,
                sourceLanguage: sourceLanguage,
                sourceLanguageMode: sourceLanguageMode,
                targetLanguages: targetLanguages,
                glossaryId: glossaryId,
                formality: formality,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}