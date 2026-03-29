//HintName: G.Models.GlossaryDictionary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary contained in a multilingual glossary. Each dictionary contains the mapping of source terms to target language terms.
    /// </summary>
    public sealed partial class GlossaryDictionary
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
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </summary>
        /// <example>Hello	Guten Tag</example>
        [global::Newtonsoft.Json.JsonProperty("entries")]
        public string? Entries { get; set; }

        /// <summary>
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </summary>
        /// <example>tsv</example>
        [global::Newtonsoft.Json.JsonProperty("entries_format")]
        public global::G.GlossaryEntriesFormat? EntriesFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryDictionary" /> class.
        /// </summary>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="entries">
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </param>
        /// <param name="entriesFormat">
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </param>
        public GlossaryDictionary(
            global::G.GlossarySourceLanguage? sourceLang,
            global::G.GlossaryTargetLanguage? targetLang,
            string? entries,
            global::G.GlossaryEntriesFormat? entriesFormat)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.Entries = entries;
            this.EntriesFormat = entriesFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryDictionary" /> class.
        /// </summary>
        public GlossaryDictionary()
        {
        }
    }
}