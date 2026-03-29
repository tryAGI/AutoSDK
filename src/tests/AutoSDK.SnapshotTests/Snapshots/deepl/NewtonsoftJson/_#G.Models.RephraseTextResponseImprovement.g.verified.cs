//HintName: G.Models.RephraseTextResponseImprovement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RephraseTextResponseImprovement
    {
        /// <summary>
        /// The language detected in the source text.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("detected_source_language")]
        public string? DetectedSourceLanguage { get; set; }

        /// <summary>
        /// The improved text.<br/>
        /// Example: This is a sample sentence to improve.
        /// </summary>
        /// <example>This is a sample sentence to improve.</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextResponseImprovement" /> class.
        /// </summary>
        /// <param name="detectedSourceLanguage">
        /// The language detected in the source text.<br/>
        /// Example: en
        /// </param>
        /// <param name="text">
        /// The improved text.<br/>
        /// Example: This is a sample sentence to improve.
        /// </param>
        public RephraseTextResponseImprovement(
            string? detectedSourceLanguage,
            string? text)
        {
            this.DetectedSourceLanguage = detectedSourceLanguage;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RephraseTextResponseImprovement" /> class.
        /// </summary>
        public RephraseTextResponseImprovement()
        {
        }
    }
}