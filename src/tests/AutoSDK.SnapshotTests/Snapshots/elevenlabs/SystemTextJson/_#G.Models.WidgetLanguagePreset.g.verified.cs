//HintName: G.Models.WidgetLanguagePreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetLanguagePreset
    {
        /// <summary>
        /// The text contents for the selected language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// The text to display for terms and conditions in this language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_text")]
        public string? TermsText { get; set; }

        /// <summary>
        /// The HTML to display for terms and conditions in this language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_html")]
        public string? TermsHtml { get; set; }

        /// <summary>
        /// The key to display for terms and conditions in this language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_key")]
        public string? TermsKey { get; set; }

        /// <summary>
        /// The translation cache for the terms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_translation")]
        public global::G.WidgetTermsTranslation? TermsTranslation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePreset" /> class.
        /// </summary>
        /// <param name="textContents">
        /// The text contents for the selected language
        /// </param>
        /// <param name="termsText">
        /// The text to display for terms and conditions in this language
        /// </param>
        /// <param name="termsHtml">
        /// The HTML to display for terms and conditions in this language
        /// </param>
        /// <param name="termsKey">
        /// The key to display for terms and conditions in this language
        /// </param>
        /// <param name="termsTranslation">
        /// The translation cache for the terms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetLanguagePreset(
            global::G.WidgetTextContents? textContents,
            string? termsText,
            string? termsHtml,
            string? termsKey,
            global::G.WidgetTermsTranslation? termsTranslation)
        {
            this.TextContents = textContents;
            this.TermsText = termsText;
            this.TermsHtml = termsHtml;
            this.TermsKey = termsKey;
            this.TermsTranslation = termsTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePreset" /> class.
        /// </summary>
        public WidgetLanguagePreset()
        {
        }
    }
}