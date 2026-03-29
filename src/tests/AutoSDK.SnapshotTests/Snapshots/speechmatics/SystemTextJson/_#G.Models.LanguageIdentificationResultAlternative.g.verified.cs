//HintName: G.Models.LanguageIdentificationResultAlternative.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageIdentificationResultAlternative
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResultAlternative" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageIdentificationResultAlternative(
            string? language,
            double? confidence)
        {
            this.Language = language;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResultAlternative" /> class.
        /// </summary>
        public LanguageIdentificationResultAlternative()
        {
        }
    }
}