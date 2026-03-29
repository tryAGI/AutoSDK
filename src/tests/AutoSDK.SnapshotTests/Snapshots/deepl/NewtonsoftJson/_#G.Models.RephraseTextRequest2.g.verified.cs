//HintName: G.Models.RephraseTextRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RephraseTextRequest2
    {
        /// <summary>
        /// Text to be improved. Only UTF-8-encoded plain text is supported. Improvements are returned in the same order as they are requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Text { get; set; } = default!;

        /// <summary>
        /// The language for the text improvement. Options currently available:<br/>
        ///  * `de` - German<br/>
        ///  * `en` - English (unspecified variant, defaults to `en-US`)<br/>
        ///  * `en-GB` - English (British)<br/>
        ///  * `en-US` - English (American)<br/>
        ///  * `es` - Spanish<br/>
        ///  * `fr` - French<br/>
        ///  * `it` - Italian<br/>
        ///  * `pt` - Portuguese (unspecified variant, defaults to `pt-PT`)<br/>
        ///  * `pt-BR` - Portuguese (Brazilian)<br/>
        ///  * `pt-PT` - Portuguese (all Portuguese variants excluding Brazilian Portuguese)<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::Newtonsoft.Json.JsonProperty("target_lang")]
        public global::G.TargetLanguageWrite? TargetLang { get; set; }

        /// <summary>
        /// Specify a style to rephrase your text in a way that fits your audience and goals.<br/>
        /// The `prefer_` prefix allows falling back to the default style if the language does not yet support styles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("writing_style")]
        public global::G.WritingStyle? WritingStyle { get; set; }

        /// <summary>
        /// Specify the desired tone for your text.<br/>
        /// The `prefer_` prefix allows falling back to the default tone if the language does not yet support tones.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tone")]
        public global::G.WritingTone? Tone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextRequest2" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to be improved. Only UTF-8-encoded plain text is supported. Improvements are returned in the same order as they are requested.
        /// </param>
        /// <param name="targetLang">
        /// The language for the text improvement. Options currently available:<br/>
        ///  * `de` - German<br/>
        ///  * `en` - English (unspecified variant, defaults to `en-US`)<br/>
        ///  * `en-GB` - English (British)<br/>
        ///  * `en-US` - English (American)<br/>
        ///  * `es` - Spanish<br/>
        ///  * `fr` - French<br/>
        ///  * `it` - Italian<br/>
        ///  * `pt` - Portuguese (unspecified variant, defaults to `pt-PT`)<br/>
        ///  * `pt-BR` - Portuguese (Brazilian)<br/>
        ///  * `pt-PT` - Portuguese (all Portuguese variants excluding Brazilian Portuguese)<br/>
        /// Example: de
        /// </param>
        /// <param name="writingStyle">
        /// Specify a style to rephrase your text in a way that fits your audience and goals.<br/>
        /// The `prefer_` prefix allows falling back to the default style if the language does not yet support styles.
        /// </param>
        /// <param name="tone">
        /// Specify the desired tone for your text.<br/>
        /// The `prefer_` prefix allows falling back to the default tone if the language does not yet support tones.
        /// </param>
        public RephraseTextRequest2(
            global::System.Collections.Generic.IList<string> text,
            global::G.TargetLanguageWrite? targetLang,
            global::G.WritingStyle? writingStyle,
            global::G.WritingTone? tone)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TargetLang = targetLang;
            this.WritingStyle = writingStyle;
            this.Tone = tone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextRequest2" /> class.
        /// </summary>
        public RephraseTextRequest2()
        {
        }
    }
}