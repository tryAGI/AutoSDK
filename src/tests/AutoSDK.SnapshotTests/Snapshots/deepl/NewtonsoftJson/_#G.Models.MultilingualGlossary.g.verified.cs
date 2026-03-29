//HintName: G.Models.MultilingualGlossary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"glossary_id":"def3a26b-3e84-45b3-84ae-0c0aaf3525f7","name":"My Glossary","dictionaries":[{"source_lang":"en","target_lang":"de","entry_count":1}],"creation_time":"2021-08-03T14:16:18.329Z"}
    /// </summary>
    public sealed partial class MultilingualGlossary
    {
        /// <summary>
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::Newtonsoft.Json.JsonProperty("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Name associated with the glossary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of dictionaries contained in this glossary.<br/>
        /// Each dictionary contains a source and target language, as well as pairs of source and target entries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dictionaries")]
        public global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? Dictionaries { get; set; }

        /// <summary>
        /// The creation time of the glossary in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossary" /> class.
        /// </summary>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="name">
        /// Name associated with the glossary.
        /// </param>
        /// <param name="dictionaries">
        /// List of dictionaries contained in this glossary.<br/>
        /// Each dictionary contains a source and target language, as well as pairs of source and target entries.
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the glossary in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </param>
        public MultilingualGlossary(
            string? glossaryId,
            string? name,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? dictionaries,
            global::System.DateTime? creationTime)
        {
            this.GlossaryId = glossaryId;
            this.Name = name;
            this.Dictionaries = dictionaries;
            this.CreationTime = creationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossary" /> class.
        /// </summary>
        public MultilingualGlossary()
        {
        }
    }
}