//HintName: G.Models.ListGlossaryLanguagesResponseSupportedLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGlossaryLanguagesResponseSupportedLanguage
    {
        /// <summary>
        /// The language in which the source texts in the glossary are specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLang { get; set; }

        /// <summary>
        /// The language in which the target texts in the glossary are specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossaryLanguagesResponseSupportedLanguage" /> class.
        /// </summary>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGlossaryLanguagesResponseSupportedLanguage(
            string sourceLang,
            string targetLang)
        {
            this.SourceLang = sourceLang ?? throw new global::System.ArgumentNullException(nameof(sourceLang));
            this.TargetLang = targetLang ?? throw new global::System.ArgumentNullException(nameof(targetLang));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGlossaryLanguagesResponseSupportedLanguage" /> class.
        /// </summary>
        public ListGlossaryLanguagesResponseSupportedLanguage()
        {
        }
    }
}