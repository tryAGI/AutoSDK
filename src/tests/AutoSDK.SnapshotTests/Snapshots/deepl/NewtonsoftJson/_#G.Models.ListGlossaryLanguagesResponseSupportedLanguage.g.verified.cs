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
        [global::Newtonsoft.Json.JsonProperty("source_lang", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceLang { get; set; } = default!;

        /// <summary>
        /// The language in which the target texts in the glossary are specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_lang", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetLang { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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