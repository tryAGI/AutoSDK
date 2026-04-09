//HintName: G.Models.MonolingualGlossary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"glossary_id":"def3a26b-3e84-45b3-84ae-0c0aaf3525f7","ready":true,"name":"My Glossary","source_lang":"en","target_lang":"de","creation_time":"2021-08-03T14:16:18.329Z","entry_count":1}
    /// </summary>
    public sealed partial class MonolingualGlossary
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
        /// Indicates if the newly created glossary can already be used in `translate` requests.<br/>
        /// If the created glossary is not yet ready, you have to wait and check the `ready` status<br/>
        /// of the glossary before using it in a `translate` request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("source_lang")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GlossarySourceLanguageJsonConverter))]
        public global::G.GlossarySourceLanguage? SourceLang { get; set; }

        /// <summary>
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::Newtonsoft.Json.JsonProperty("target_lang")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GlossaryTargetLanguageJsonConverter))]
        public global::G.GlossaryTargetLanguage? TargetLang { get; set; }

        /// <summary>
        /// The creation time of the glossary in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

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
        /// Initializes a new instance of the <see cref="MonolingualGlossary" /> class.
        /// </summary>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="name">
        /// Name associated with the glossary.
        /// </param>
        /// <param name="ready">
        /// Indicates if the newly created glossary can already be used in `translate` requests.<br/>
        /// If the created glossary is not yet ready, you have to wait and check the `ready` status<br/>
        /// of the glossary before using it in a `translate` request.
        /// </param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the glossary in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </param>
        /// <param name="entryCount">
        /// The number of entries in the glossary.
        /// </param>
        public MonolingualGlossary(
            string? glossaryId,
            string? name,
            bool? ready,
            global::G.GlossarySourceLanguage? sourceLang,
            global::G.GlossaryTargetLanguage? targetLang,
            global::System.DateTime? creationTime,
            int? entryCount)
        {
            this.GlossaryId = glossaryId;
            this.Name = name;
            this.Ready = ready;
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.CreationTime = creationTime;
            this.EntryCount = entryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonolingualGlossary" /> class.
        /// </summary>
        public MonolingualGlossary()
        {
        }
    }
}