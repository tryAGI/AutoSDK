//HintName: G.Models.MurfApiTranslationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MurfApiTranslationRequest
    {
        /// <summary>
        /// The language code for the target translation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLanguage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// List of texts to translate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Texts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationRequest" /> class.
        /// </summary>
        /// <param name="targetLanguage">
        /// The language code for the target translation
        /// </param>
        /// <param name="texts">
        /// List of texts to translate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MurfApiTranslationRequest(
            string targetLanguage,
            global::System.Collections.Generic.IList<string> texts)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationRequest" /> class.
        /// </summary>
        public MurfApiTranslationRequest()
        {
        }
    }
}