//HintName: G.Models.Corpus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Corpus
    {
        /// <summary>
        /// Vectara ID of the corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Name for the corpus. This value defaults to the key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Corpus description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Specifies whether the corpus is enabled or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates that this corpus does not store documents and stores chats instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_history_corpus")]
        public bool? ChatHistoryCorpus { get; set; }

        /// <summary>
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// This swaps the semantics of the encoder used at query time.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries_are_answers")]
        public bool? QueriesAreAnswers { get; set; } = false;

        /// <summary>
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// This swaps the semantics of the encoder used at indexing.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents_are_questions")]
        public bool? DocumentsAreQuestions { get; set; } = false;

        /// <summary>
        /// The encoder used by the corpus.<br/>
        /// *Deprecated*: use `encoder_name` instead
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoder_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EncoderId { get; set; }

        /// <summary>
        /// The encoder used by the corpus.<br/>
        /// Example: boomerang
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoder_name")]
        public string? EncoderName { get; set; }

        /// <summary>
        /// The new filter attributes of the corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_attributes")]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute>? FilterAttributes { get; set; }

        /// <summary>
        /// The custom dimensions of all document parts inside the corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limits")]
        public global::G.CorpusLimits? Limits { get; set; }

        /// <summary>
        /// Indicates when the corpus was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}