//HintName: G.Models.MultilingualGlossaryEntriesInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultilingualGlossaryEntriesInformation
    {
        /// <summary>
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("source_lang")]
        public global::G.GlossarySourceLanguage? SourceLang { get; set; }

        /// <summary>
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::Newtonsoft.Json.JsonProperty("target_lang")]
        public global::G.GlossaryTargetLanguage? TargetLang { get; set; }

        /// <summary>
        /// The number of entries in the glossary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entry_count")]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesInformation" /> class.
        /// </summary>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="entryCount">
        /// The number of entries in the glossary.
        /// </param>
        public MultilingualGlossaryEntriesInformation(
            global::G.GlossarySourceLanguage? sourceLang,
            global::G.GlossaryTargetLanguage? targetLang,
            int? entryCount)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.EntryCount = entryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesInformation" /> class.
        /// </summary>
        public MultilingualGlossaryEntriesInformation()
        {
        }
    }
}