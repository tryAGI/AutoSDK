//HintName: G.Models.Translation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Translation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_text")]
        public string? SourceText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translated_text")]
        public string? TranslatedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Translation" /> class.
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="translatedText"></param>
        public Translation(
            string? sourceText,
            string? translatedText)
        {
            this.SourceText = sourceText;
            this.TranslatedText = translatedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Translation" /> class.
        /// </summary>
        public Translation()
        {
        }
    }
}