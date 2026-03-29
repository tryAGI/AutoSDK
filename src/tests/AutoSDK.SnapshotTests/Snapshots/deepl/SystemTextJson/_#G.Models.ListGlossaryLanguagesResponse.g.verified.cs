//HintName: G.Models.ListGlossaryLanguagesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGlossaryLanguagesResponse
    {
        /// <summary>
        /// The list of supported languages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_languages")]
        public global::System.Collections.Generic.IList<global::G.ListGlossaryLanguagesResponseSupportedLanguage>? SupportedLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossaryLanguagesResponse" /> class.
        /// </summary>
        /// <param name="supportedLanguages">
        /// The list of supported languages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGlossaryLanguagesResponse(
            global::System.Collections.Generic.IList<global::G.ListGlossaryLanguagesResponseSupportedLanguage>? supportedLanguages)
        {
            this.SupportedLanguages = supportedLanguages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossaryLanguagesResponse" /> class.
        /// </summary>
        public ListGlossaryLanguagesResponse()
        {
        }
    }
}