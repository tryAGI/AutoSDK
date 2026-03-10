//HintName: G.Models.WidgetLanguagePresetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetLanguagePresetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// The text contents for the selected language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_contents")]
        public global::G.WidgetTextContents? TextContents { get; set; }

        /// <summary>
        /// The text to display for terms and conditions in this language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_text")]
        public string? TermsText { get; set; }

        /// <summary>
        /// The HTML to display for terms and conditions in this language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_html")]
        public string? TermsHtml { get; set; }

        /// <summary>
        /// The key to display for terms and conditions in this language
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_key")]
        public string? TermsKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePresetResponse" /> class.
        /// </summary>
        /// <param name="firstMessage"></param>
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
        public WidgetLanguagePresetResponse(
            string? firstMessage,
            global::G.WidgetTextContents? textContents,
            string? termsText,
            string? termsHtml,
            string? termsKey)
        {
            this.FirstMessage = firstMessage;
            this.TextContents = textContents;
            this.TermsText = termsText;
            this.TermsHtml = termsHtml;
            this.TermsKey = termsKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetLanguagePresetResponse" /> class.
        /// </summary>
        public WidgetLanguagePresetResponse()
        {
        }
    }
}