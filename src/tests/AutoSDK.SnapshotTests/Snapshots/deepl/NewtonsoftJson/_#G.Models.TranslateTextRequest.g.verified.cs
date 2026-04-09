//HintName: G.Models.TranslateTextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateTextRequest
    {
        /// <summary>
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified<br/>
        /// multiple times and translations are returned in the same order as they are requested. Each of the<br/>
        /// parameter values may contain multiple sentences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Text { get; set; } = default!;

        /// <summary>
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </summary>
        /// <example>EN</example>
        [global::Newtonsoft.Json.JsonProperty("source_lang")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SourceLanguageJsonConverter))]
        public global::G.SourceLanguage? SourceLang { get; set; }

        /// <summary>
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </summary>
        /// <example>DE</example>
        [global::Newtonsoft.Json.JsonProperty("target_lang", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TargetLanguageJsonConverter))]
        public global::G.TargetLanguage TargetLang { get; set; } = default!;

        /// <summary>
        /// The `context` parameter makes it possible to include additional context that can influence a translation but is not translated itself. <br/>
        /// This additional context can potentially improve translation quality when translating short, low-context source texts such <br/>
        /// as product names on an e-commerce website, article headlines on a news website, or UI elements.<br/>
        /// For example...<br/>
        ///   - When translating a product name, you might pass the product description as context. <br/>
        ///   - When translating a news article headline, you might pass the first few sentences or a summary of the article as context.<br/>
        /// For best results, we recommend sending a few complete sentences of context in the same language as the source text. <br/>
        /// There is no size limit for the `context` parameter itself, but the request body size limit of 128 KiB still applies to <br/>
        /// all text translation requests. <br/>
        /// If you send a request with multiple `text` parameters, the `context` parameter will be applied to each one. <br/>
        /// Characters included in the `context` parameter will not be counted toward billing (i.e. there is no additional <br/>
        /// cost for using the `context` parameter, and only characters sent in the text parameter(s) will be counted toward <br/>
        /// billing for text translation even when the `context` parameter is included in a request).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// When true, the response will include the billed_characters parameter, giving the <br/>
        /// number of characters from the request that will be counted by DeepL for billing purposes.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_billed_characters")]
        public bool? ShowBilledCharacters { get; set; }

        /// <summary>
        /// Sets whether the translation engine should first split the input into sentences. For text translations where <br/>
        /// `tag_handling` is not set to `html`, the default value is `1`, meaning the engine splits on punctuation and on newlines.<br/>
        /// For text translations where `tag_handling=html`, the default value is `nonewlines`, meaning the engine splits on punctuation only, ignoring newlines.  <br/>
        /// The use of `nonewlines` as the default value for text translations where `tag_handling=html` is new behavior that was implemented in November 2022, <br/>
        /// when HTML handling was moved out of beta. <br/>
        /// Possible values are: <br/>
        ///  * `0` - no splitting at all, whole input is treated as one sentence<br/>
        ///  * `1` (default when `tag_handling` is not set to `html`) - splits on punctuation and on newlines<br/>
        ///  * `nonewlines` (default when `tag_handling=html`) - splits on punctuation only, ignoring newlines<br/>
        /// For applications that send one sentence per text parameter, we recommend setting `split_sentences` to `0`, in order to prevent the engine from splitting the sentence unintentionally.<br/>
        /// Please note that newlines will split sentences when `split_sentences=1`. We recommend cleaning files so they don't contain breaking sentences or setting the parameter `split_sentences` to `nonewlines`.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split_sentences")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SplitSentencesOptionJsonConverter))]
        public global::G.SplitSentencesOption? SplitSentences { get; set; }

        /// <summary>
        /// Sets whether the translation engine should respect the original formatting, even if it would usually correct some aspects.<br/>
        /// The formatting aspects affected by this setting include:<br/>
        ///  * Punctuation at the beginning and end of the sentence<br/>
        ///  * Upper/lower case at the beginning of the sentence<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_formatting")]
        public bool? PreserveFormatting { get; set; }

        /// <summary>
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature currently only works for target languages<br/>
        /// `DE` (German),<br/>
        /// `FR` (French),<br/>
        /// `IT` (Italian),<br/>
        /// `ES` (Spanish),<br/>
        /// `ES-419` (Latin American Spanish),<br/>
        /// `NL` (Dutch),<br/>
        /// `PL` (Polish),<br/>
        /// `PT-BR` and `PT-PT` (Portuguese),<br/>
        /// `JA` (Japanese),<br/>
        /// and `RU` (Russian).<br/>
        /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
        /// Setting this parameter with a target language that does not support formality will fail,<br/>
        /// unless one of the `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formality")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FormalityJsonConverter))]
        public global::G.Formality? Formality { get; set; }

        /// <summary>
        /// Specifies which DeepL model should be used for translation.<br/>
        /// Possible values are:<br/>
        /// * `latency_optimized` (default) - uses lower latency “classic” translation models, which support all language pairs;<br/>
        ///   default value<br/>
        /// * `quality_optimized` - uses higher latency, improved quality “next-gen” translation models, which support only a<br/>
        ///   subset of language pairs; if a language pair that is not supported by next-gen models is included in the<br/>
        ///   request, it will fail. Consider using prefer_quality_optimized instead.<br/>
        /// * `prefer_quality_optimized` - prioritizes use of higher latency, improved quality “next-gen” translation models,<br/>
        ///   which support only a subset of DeepL languages; if a request includes a language pair not supported by<br/>
        ///   next-gen models, the request will fall back to latency_optimized classic models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelTypeJsonConverter))]
        public global::G.ModelType? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Specify a list of instructions to customize the translation behavior. Up to 10 custom instructions can be specified, each with a maximum of 300 characters.<br/>
        /// **Important:**  The target language must be `de`, `en`, `es`, `fr`, `it`, `ja`, `ko`, `zh` or any variants of these languages.<br/>
        /// **Note:** Any request with the `custom_instructions` parameter enabled will default to use the `quality_optimized` model type. Requests combining `custom_instructions` and `model_type: latency_optimized` will be rejected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_instructions")]
        public global::System.Collections.Generic.IList<string>? CustomInstructions { get; set; }

        /// <summary>
        /// Enables 81 additional beta languages. See the full list at https://developers.deepl.com/docs/getting-started/supported-languages#beta-languages. **Note:** Any request with the `enable_beta_languages` parameter enabled will use `quality_optimized` models. Requests combining `enable_beta_languages: true` and `model_type: latency_optimized` will be rejected. Beta languages do not support formality or glossaries.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_beta_languages")]
        public bool? EnableBetaLanguages { get; set; }

        /// <summary>
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`: Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).<br/>
        ///  * `html`: Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_handling")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TagHandlingOptionJsonConverter))]
        public global::G.TagHandlingOption? TagHandling { get; set; }

        /// <summary>
        /// The automatic detection of the XML structure won't yield best results in all XML files. You can disable this automatic mechanism altogether by setting the `outline_detection` parameter to `false` and selecting the tags that should be considered structure tags. This will split sentences using the `splitting_tags` parameter.<br/>
        /// In the example below, we achieve the same results as the automatic engine by disabling automatic detection with `outline_detection=0` and setting the parameters manually to `tag_handling=xml`, `split_sentences=nonewlines`,  and `splitting_tags=par,title`.<br/>
        ///  * Example request:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;A document's title&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;This is the first sentence. Followed by a second one.&lt;/par&gt;<br/>
        ///        &lt;par&gt;This is the third sentence.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        ///  * Example response:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;Der Titel eines Dokuments&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;Das ist der erste Satz. Gefolgt von einem zweiten.&lt;/par&gt;<br/>
        ///        &lt;par&gt;Dies ist der dritte Satz.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        /// While this approach is slightly more complicated, it allows for greater control over the structure of the translation output.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outline_detection")]
        public bool? OutlineDetection { get; set; }

        /// <summary>
        /// List of XML tags which never cause splits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("non_splitting_tags")]
        public global::System.Collections.Generic.IList<string>? NonSplittingTags { get; set; }

        /// <summary>
        /// List of XML tags which always cause splits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("splitting_tags")]
        public global::System.Collections.Generic.IList<string>? SplittingTags { get; set; }

        /// <summary>
        /// List of XML tags that indicate text not to be translated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_tags")]
        public global::System.Collections.Generic.IList<string>? IgnoreTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified<br/>
        /// multiple times and translations are returned in the same order as they are requested. Each of the<br/>
        /// parameter values may contain multiple sentences.
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </param>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </param>
        /// <param name="context">
        /// The `context` parameter makes it possible to include additional context that can influence a translation but is not translated itself. <br/>
        /// This additional context can potentially improve translation quality when translating short, low-context source texts such <br/>
        /// as product names on an e-commerce website, article headlines on a news website, or UI elements.<br/>
        /// For example...<br/>
        ///   - When translating a product name, you might pass the product description as context. <br/>
        ///   - When translating a news article headline, you might pass the first few sentences or a summary of the article as context.<br/>
        /// For best results, we recommend sending a few complete sentences of context in the same language as the source text. <br/>
        /// There is no size limit for the `context` parameter itself, but the request body size limit of 128 KiB still applies to <br/>
        /// all text translation requests. <br/>
        /// If you send a request with multiple `text` parameters, the `context` parameter will be applied to each one. <br/>
        /// Characters included in the `context` parameter will not be counted toward billing (i.e. there is no additional <br/>
        /// cost for using the `context` parameter, and only characters sent in the text parameter(s) will be counted toward <br/>
        /// billing for text translation even when the `context` parameter is included in a request).
        /// </param>
        /// <param name="showBilledCharacters">
        /// When true, the response will include the billed_characters parameter, giving the <br/>
        /// number of characters from the request that will be counted by DeepL for billing purposes.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".
        /// </param>
        /// <param name="splitSentences">
        /// Sets whether the translation engine should first split the input into sentences. For text translations where <br/>
        /// `tag_handling` is not set to `html`, the default value is `1`, meaning the engine splits on punctuation and on newlines.<br/>
        /// For text translations where `tag_handling=html`, the default value is `nonewlines`, meaning the engine splits on punctuation only, ignoring newlines.  <br/>
        /// The use of `nonewlines` as the default value for text translations where `tag_handling=html` is new behavior that was implemented in November 2022, <br/>
        /// when HTML handling was moved out of beta. <br/>
        /// Possible values are: <br/>
        ///  * `0` - no splitting at all, whole input is treated as one sentence<br/>
        ///  * `1` (default when `tag_handling` is not set to `html`) - splits on punctuation and on newlines<br/>
        ///  * `nonewlines` (default when `tag_handling=html`) - splits on punctuation only, ignoring newlines<br/>
        /// For applications that send one sentence per text parameter, we recommend setting `split_sentences` to `0`, in order to prevent the engine from splitting the sentence unintentionally.<br/>
        /// Please note that newlines will split sentences when `split_sentences=1`. We recommend cleaning files so they don't contain breaking sentences or setting the parameter `split_sentences` to `nonewlines`.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="preserveFormatting">
        /// Sets whether the translation engine should respect the original formatting, even if it would usually correct some aspects.<br/>
        /// The formatting aspects affected by this setting include:<br/>
        ///  * Punctuation at the beginning and end of the sentence<br/>
        ///  * Upper/lower case at the beginning of the sentence<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: false
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature currently only works for target languages<br/>
        /// `DE` (German),<br/>
        /// `FR` (French),<br/>
        /// `IT` (Italian),<br/>
        /// `ES` (Spanish),<br/>
        /// `ES-419` (Latin American Spanish),<br/>
        /// `NL` (Dutch),<br/>
        /// `PL` (Polish),<br/>
        /// `PT-BR` and `PT-PT` (Portuguese),<br/>
        /// `JA` (Japanese),<br/>
        /// and `RU` (Russian).<br/>
        /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
        /// Setting this parameter with a target language that does not support formality will fail,<br/>
        /// unless one of the `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default
        /// </param>
        /// <param name="modelType">
        /// Specifies which DeepL model should be used for translation.<br/>
        /// Possible values are:<br/>
        /// * `latency_optimized` (default) - uses lower latency “classic” translation models, which support all language pairs;<br/>
        ///   default value<br/>
        /// * `quality_optimized` - uses higher latency, improved quality “next-gen” translation models, which support only a<br/>
        ///   subset of language pairs; if a language pair that is not supported by next-gen models is included in the<br/>
        ///   request, it will fail. Consider using prefer_quality_optimized instead.<br/>
        /// * `prefer_quality_optimized` - prioritizes use of higher latency, improved quality “next-gen” translation models,<br/>
        ///   which support only a subset of DeepL languages; if a request includes a language pair not supported by<br/>
        ///   next-gen models, the request will fall back to latency_optimized classic models.
        /// </param>
        /// <param name="glossaryId"></param>
        /// <param name="customInstructions">
        /// Specify a list of instructions to customize the translation behavior. Up to 10 custom instructions can be specified, each with a maximum of 300 characters.<br/>
        /// **Important:**  The target language must be `de`, `en`, `es`, `fr`, `it`, `ja`, `ko`, `zh` or any variants of these languages.<br/>
        /// **Note:** Any request with the `custom_instructions` parameter enabled will default to use the `quality_optimized` model type. Requests combining `custom_instructions` and `model_type: latency_optimized` will be rejected.
        /// </param>
        /// <param name="enableBetaLanguages">
        /// Enables 81 additional beta languages. See the full list at https://developers.deepl.com/docs/getting-started/supported-languages#beta-languages. **Note:** Any request with the `enable_beta_languages` parameter enabled will use `quality_optimized` models. Requests combining `enable_beta_languages: true` and `model_type: latency_optimized` will be rejected. Beta languages do not support formality or glossaries.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tagHandling">
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`: Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).<br/>
        ///  * `html`: Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).
        /// </param>
        /// <param name="outlineDetection">
        /// The automatic detection of the XML structure won't yield best results in all XML files. You can disable this automatic mechanism altogether by setting the `outline_detection` parameter to `false` and selecting the tags that should be considered structure tags. This will split sentences using the `splitting_tags` parameter.<br/>
        /// In the example below, we achieve the same results as the automatic engine by disabling automatic detection with `outline_detection=0` and setting the parameters manually to `tag_handling=xml`, `split_sentences=nonewlines`,  and `splitting_tags=par,title`.<br/>
        ///  * Example request:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;A document's title&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;This is the first sentence. Followed by a second one.&lt;/par&gt;<br/>
        ///        &lt;par&gt;This is the third sentence.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        ///  * Example response:<br/>
        ///    ```<br/>
        ///    &lt;document&gt;<br/>
        ///      &lt;meta&gt;<br/>
        ///        &lt;title&gt;Der Titel eines Dokuments&lt;/title&gt;<br/>
        ///      &lt;/meta&gt;<br/>
        ///      &lt;content&gt;<br/>
        ///        &lt;par&gt;Das ist der erste Satz. Gefolgt von einem zweiten.&lt;/par&gt;<br/>
        ///        &lt;par&gt;Dies ist der dritte Satz.&lt;/par&gt;<br/>
        ///      &lt;/content&gt;<br/>
        ///    &lt;/document&gt;<br/>
        ///    ```<br/>
        /// While this approach is slightly more complicated, it allows for greater control over the structure of the translation output.<br/>
        /// Note: for requests sent as URL-encoded forms, boolean values should be specified as "1" or "0".<br/>
        /// Default Value: true
        /// </param>
        /// <param name="nonSplittingTags">
        /// List of XML tags which never cause splits.
        /// </param>
        /// <param name="splittingTags">
        /// List of XML tags which always cause splits.
        /// </param>
        /// <param name="ignoreTags">
        /// List of XML tags that indicate text not to be translated.
        /// </param>
        public TranslateTextRequest(
            global::System.Collections.Generic.IList<string> text,
            global::G.TargetLanguage targetLang,
            global::G.SourceLanguage? sourceLang,
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
            global::System.Collections.Generic.IList<string>? ignoreTags)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.Context = context;
            this.ShowBilledCharacters = showBilledCharacters;
            this.SplitSentences = splitSentences;
            this.PreserveFormatting = preserveFormatting;
            this.Formality = formality;
            this.ModelType = modelType;
            this.GlossaryId = glossaryId;
            this.CustomInstructions = customInstructions;
            this.EnableBetaLanguages = enableBetaLanguages;
            this.TagHandling = tagHandling;
            this.OutlineDetection = outlineDetection;
            this.NonSplittingTags = nonSplittingTags;
            this.SplittingTags = splittingTags;
            this.IgnoreTags = ignoreTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextRequest" /> class.
        /// </summary>
        public TranslateTextRequest()
        {
        }
    }
}