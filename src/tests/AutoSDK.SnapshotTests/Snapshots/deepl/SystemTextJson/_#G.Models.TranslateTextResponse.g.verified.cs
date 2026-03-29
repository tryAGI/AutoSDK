//HintName: G.Models.TranslateTextResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateTextResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        public global::System.Collections.Generic.IList<global::G.TranslateTextResponseTranslation>? Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponse" /> class.
        /// </summary>
        /// <param name="translations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateTextResponse(
            global::System.Collections.Generic.IList<global::G.TranslateTextResponseTranslation>? translations)
        {
            this.Translations = translations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextResponse" /> class.
        /// </summary>
        public TranslateTextResponse()
        {
        }
    }
}