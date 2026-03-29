//HintName: G.Models.MurfApiTranslationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MurfApiTranslationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        public global::System.Collections.Generic.IList<global::G.Translation>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationResponse" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="translations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MurfApiTranslationResponse(
            global::G.Metadata? metadata,
            global::System.Collections.Generic.IList<global::G.Translation>? translations)
        {
            this.Metadata = metadata;
            this.Translations = translations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationResponse" /> class.
        /// </summary>
        public MurfApiTranslationResponse()
        {
        }
    }
}