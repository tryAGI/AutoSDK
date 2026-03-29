//HintName: G.Commands.TranslateTextTranslateTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateTextTranslateTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<string> text,
            global::G.SourceLanguage? sourceLang,
            global::G.TargetLanguage targetLang,
            string? context,
            bool? showBilledCharacters,
            global::G.SplitSentencesOption? splitSentences,
            bool? preserveFormatting,
            global::G.Formality? formality,
            global::G.ModelType? modelType,
            string? glossaryId,
            global::System.Collections.Generic.IList<string>? customInstructions,
            bool? enableBetaLanguages,
            global::G.TagHandlingOption? tagHandling,
            bool? outlineDetection,
            global::System.Collections.Generic.IList<string>? nonSplittingTags,
            global::System.Collections.Generic.IList<string>? splittingTags,
            global::System.Collections.Generic.IList<string>? ignoreTags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranslateTextResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Text { get; } = new(
            name: "text")
        {
            Description = @"Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified
multiple times and translations are returned in the same order as they are requested. Each of the
parameter values may contain multiple sentences.",
        };

        private global::System.CommandLine.Argument<global::G.TargetLanguage> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"The language into which the text should be translated.

**Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.",
        };

        private global::System.CommandLine.Option<global::G.SourceLanguage?> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = @"Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.

**Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.",
        };

        private global::System.CommandLine.Option<string?> Context { get; } = new(
            name: "context")
        {
            Description = @"The `context` parameter makes it possible to include additional context that can influence a translation but is not translated itself. 
This additional context can potentially improve translation quality when translating short, low-context source texts such 
as product names on an e-commerce website, article headlines on a news website, or UI elements.


For example...
  - When translating a product name, you might pass the product description as context. 
  - When translating a news article headline, you might pass the first few sentences or a summary of the article as context.


For best results, we recommend sending a few complete sentences of context in the same language as the source text. 
There is no size limit for the `context` parameter itself, but the request body size limit of 128 KiB still applies to 
all text translation requests. 


If you send a request with multiple `text` parameters, the `context` parameter will be applied to each one. 


Characters included in the `context` parameter will not be counted toward billing (i.e. there is no additional 
cost for using the `context` parameter, and only characters sent in the text parameter(s) will be counted toward 
billing for text translation even when the `context` parameter is included in a request).",
        };

        private global::System.CommandLine.Option<bool?> ShowBilledCharacters { get; } = new(
            name: "showBilledCharacters")
        {
            Description = @"When true, the response will include the billed_characters parameter, giving the 
number of characters from the request that will be counted by DeepL for billing purposes.

Note: for requests sent as URL-encoded forms, boolean values should be specified as ""1"" or ""0"".",
        };

        private global::System.CommandLine.Option<global::G.SplitSentencesOption?> SplitSentences { get; } = new(
            name: "splitSentences")
        {
            Description = @"Sets whether the translation engine should first split the input into sentences. For text translations where 
`tag_handling` is not set to `html`, the default value is `1`, meaning the engine splits on punctuation and on newlines.

For text translations where `tag_handling=html`, the default value is `nonewlines`, meaning the engine splits on punctuation only, ignoring newlines.  

The use of `nonewlines` as the default value for text translations where `tag_handling=html` is new behavior that was implemented in November 2022, 
when HTML handling was moved out of beta. 

Possible values are: 

 * `0` - no splitting at all, whole input is treated as one sentence
 * `1` (default when `tag_handling` is not set to `html`) - splits on punctuation and on newlines
 * `nonewlines` (default when `tag_handling=html`) - splits on punctuation only, ignoring newlines

For applications that send one sentence per text parameter, we recommend setting `split_sentences` to `0`, in order to prevent the engine from splitting the sentence unintentionally.


Please note that newlines will split sentences when `split_sentences=1`. We recommend cleaning files so they don't contain breaking sentences or setting the parameter `split_sentences` to `nonewlines`.",
        };

        private global::System.CommandLine.Option<bool?> PreserveFormatting { get; } = new(
            name: "preserveFormatting")
        {
            Description = @"Sets whether the translation engine should respect the original formatting, even if it would usually correct some aspects.

The formatting aspects affected by this setting include:
 * Punctuation at the beginning and end of the sentence
 * Upper/lower case at the beginning of the sentence

Note: for requests sent as URL-encoded forms, boolean values should be specified as ""1"" or ""0"".",
        };

        private global::System.CommandLine.Option<global::G.Formality?> Formality { get; } = new(
            name: "formality")
        {
            Description = @"Sets whether the translated text should lean towards formal or informal language.
This feature currently only works for target languages
`DE` (German),
`FR` (French),
`IT` (Italian),
`ES` (Spanish),
`ES-419` (Latin American Spanish),
`NL` (Dutch),
`PL` (Polish),
`PT-BR` and `PT-PT` (Portuguese),
`JA` (Japanese),
and `RU` (Russian).
Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).
Setting this parameter with a target language that does not support formality will fail,
unless one of the `prefer_...` options are used.
Possible options are:
  * `default` (default)
  * `more` - for a more formal language
  * `less` - for a more informal language
  * `prefer_more` - for a more formal language if available, otherwise fallback to default formality
  * `prefer_less` - for a more informal language if available, otherwise fallback to default formality",
        };

        private global::System.CommandLine.Option<global::G.ModelType?> ModelType { get; } = new(
            name: "modelType")
        {
            Description = @"Specifies which DeepL model should be used for translation.

Possible values are:
* `latency_optimized` (default) - uses lower latency “classic” translation models, which support all language pairs;
  default value
* `quality_optimized` - uses higher latency, improved quality “next-gen” translation models, which support only a
  subset of language pairs; if a language pair that is not supported by next-gen models is included in the
  request, it will fail. Consider using prefer_quality_optimized instead.
* `prefer_quality_optimized` - prioritizes use of higher latency, improved quality “next-gen” translation models,
  which support only a subset of DeepL languages; if a request includes a language pair not supported by
  next-gen models, the request will fall back to latency_optimized classic models.",
        };

        private global::System.CommandLine.Option<string?> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> CustomInstructions { get; } = new(
            name: "customInstructions")
        {
            Description = @"Specify a list of instructions to customize the translation behavior. Up to 10 custom instructions can be specified, each with a maximum of 300 characters.

**Important:**  The target language must be `de`, `en`, `es`, `fr`, `it`, `ja`, `ko`, `zh` or any variants of these languages.

**Note:** Any request with the `custom_instructions` parameter enabled will default to use the `quality_optimized` model type. Requests combining `custom_instructions` and `model_type: latency_optimized` will be rejected.",
        };

        private global::System.CommandLine.Option<bool?> EnableBetaLanguages { get; } = new(
            name: "enableBetaLanguages")
        {
            Description = @"Enables 81 additional beta languages. See the full list at https://developers.deepl.com/docs/getting-started/supported-languages#beta-languages. **Note:** Any request with the `enable_beta_languages` parameter enabled will use `quality_optimized` models. Requests combining `enable_beta_languages: true` and `model_type: latency_optimized` will be rejected. Beta languages do not support formality or glossaries.",
        };

        private global::System.CommandLine.Option<global::G.TagHandlingOption?> TagHandling { get; } = new(
            name: "tagHandling")
        {
            Description = @"Sets which kind of tags should be handled. Options currently available:
 * `xml`: Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).
 * `html`: Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).",
        };

        private global::System.CommandLine.Option<bool?> OutlineDetection { get; } = new(
            name: "outlineDetection")
        {
            Description = @"The automatic detection of the XML structure won't yield best results in all XML files. You can disable this automatic mechanism altogether by setting the `outline_detection` parameter to `false` and selecting the tags that should be considered structure tags. This will split sentences using the `splitting_tags` parameter.


In the example below, we achieve the same results as the automatic engine by disabling automatic detection with `outline_detection=0` and setting the parameters manually to `tag_handling=xml`, `split_sentences=nonewlines`,  and `splitting_tags=par,title`.
 * Example request:
   ```
   <document>
     <meta>
       <title>A document's title</title>
     </meta>
     <content>
       <par>This is the first sentence. Followed by a second one.</par>
       <par>This is the third sentence.</par>
     </content>
   </document>
   ```
 * Example response:
   ```
   <document>
     <meta>
       <title>Der Titel eines Dokuments</title>
     </meta>
     <content>
       <par>Das ist der erste Satz. Gefolgt von einem zweiten.</par>
       <par>Dies ist der dritte Satz.</par>
     </content>
   </document>
   ```
While this approach is slightly more complicated, it allows for greater control over the structure of the translation output.

Note: for requests sent as URL-encoded forms, boolean values should be specified as ""1"" or ""0"".",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> NonSplittingTags { get; } = new(
            name: "nonSplittingTags")
        {
            Description = @"List of XML tags which never cause splits.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SplittingTags { get; } = new(
            name: "splittingTags")
        {
            Description = @"List of XML tags which always cause splits.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IgnoreTags { get; } = new(
            name: "ignoreTags")
        {
            Description = @"List of XML tags that indicate text not to be translated.",
        };


        public TranslateTextTranslateTextCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "translate",
            description: @"The translate function.


The total request body size must not exceed 128 KiB (128 · 1024 bytes). Please split up your text into multiple
calls if it exceeds this limit.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Text);
            Arguments.Add(TargetLang);
            Options.Add(SourceLang);
            Options.Add(Context);
            Options.Add(ShowBilledCharacters);
            Options.Add(SplitSentences);
            Options.Add(PreserveFormatting);
            Options.Add(Formality);
            Options.Add(ModelType);
            Options.Add(GlossaryId);
            Options.Add(CustomInstructions);
            Options.Add(EnableBetaLanguages);
            Options.Add(TagHandling);
            Options.Add(OutlineDetection);
            Options.Add(NonSplittingTags);
            Options.Add(SplittingTags);
            Options.Add(IgnoreTags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var text = parseResult.GetRequiredValue(Text);
            var sourceLang = parseResult.GetRequiredValue(SourceLang);
            var targetLang = parseResult.GetRequiredValue(TargetLang);
            var context = parseResult.GetRequiredValue(Context);
            var showBilledCharacters = parseResult.GetRequiredValue(ShowBilledCharacters);
            var splitSentences = parseResult.GetRequiredValue(SplitSentences);
            var preserveFormatting = parseResult.GetRequiredValue(PreserveFormatting);
            var formality = parseResult.GetRequiredValue(Formality);
            var modelType = parseResult.GetRequiredValue(ModelType);
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);
            var customInstructions = parseResult.GetRequiredValue(CustomInstructions);
            var enableBetaLanguages = parseResult.GetRequiredValue(EnableBetaLanguages);
            var tagHandling = parseResult.GetRequiredValue(TagHandling);
            var outlineDetection = parseResult.GetRequiredValue(OutlineDetection);
            var nonSplittingTags = parseResult.GetRequiredValue(NonSplittingTags);
            var splittingTags = parseResult.GetRequiredValue(SplittingTags);
            var ignoreTags = parseResult.GetRequiredValue(IgnoreTags);

            Validate(
                parseResult: parseResult,
                text: text,
                sourceLang: sourceLang,
                targetLang: targetLang,
                context: context,
                showBilledCharacters: showBilledCharacters,
                splitSentences: splitSentences,
                preserveFormatting: preserveFormatting,
                formality: formality,
                modelType: modelType,
                glossaryId: glossaryId,
                customInstructions: customInstructions,
                enableBetaLanguages: enableBetaLanguages,
                tagHandling: tagHandling,
                outlineDetection: outlineDetection,
                nonSplittingTags: nonSplittingTags,
                splittingTags: splittingTags,
                ignoreTags: ignoreTags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranslateText.TranslateTextAsync(
                text: text,
                sourceLang: sourceLang,
                targetLang: targetLang,
                context: context,
                showBilledCharacters: showBilledCharacters,
                splitSentences: splitSentences,
                preserveFormatting: preserveFormatting,
                formality: formality,
                modelType: modelType,
                glossaryId: glossaryId,
                customInstructions: customInstructions,
                enableBetaLanguages: enableBetaLanguages,
                tagHandling: tagHandling,
                outlineDetection: outlineDetection,
                nonSplittingTags: nonSplittingTags,
                splittingTags: splittingTags,
                ignoreTags: ignoreTags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}