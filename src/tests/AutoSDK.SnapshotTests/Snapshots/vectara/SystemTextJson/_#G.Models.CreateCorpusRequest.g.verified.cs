//HintName: G.Models.CreateCorpusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCorpusRequest
    {
        /// <summary>
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries_are_answers")]
        public bool? QueriesAreAnswers { get; set; } = false;

        /// <summary>
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_are_questions")]
        public bool? DocumentsAreQuestions { get; set; } = false;

        /// <summary>
        /// *Deprecated*: Use `encoder_name` instead.<br/>
        /// Example: enc_1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EncoderId { get; set; }

        /// <summary>
        /// The encoder used by the corpus.<br/>
        /// Example: boomerang
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_name")]
        public string? EncoderName { get; set; }

        /// <summary>
        /// The new filter attributes of the corpus. <br/>
        /// If unset then the corpus will not have filter attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_attributes")]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute>? FilterAttributes { get; set; }

        /// <summary>
        /// A custom dimension is an additional numerical field attached to a document part. You<br/>
        /// can then multiply this numerical field with a query time custom dimension of the same<br/>
        /// name. This allows boosting (or burying) document parts for arbitrary reasons.<br/>
        /// This feature is only enabled for Scale customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}