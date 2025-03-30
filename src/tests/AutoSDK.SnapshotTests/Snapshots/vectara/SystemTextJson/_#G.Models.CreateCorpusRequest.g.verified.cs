//HintName: G.Models.CreateCorpusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new corpus in the Vectara platform.
    /// </summary>
    public sealed partial class CreateCorpusRequest
    {
        /// <summary>
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </summary>
        /// <example>my-corpus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </summary>
        /// <example>My corpus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </summary>
        /// <example>Documents with important information for my prompt.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries_are_answers")]
        public bool? QueriesAreAnswers { get; set; }

        /// <summary>
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_are_questions")]
        public bool? DocumentsAreQuestions { get; set; }

        /// <summary>
        /// *Deprecated*: Use `encoder_name` instead.<br/>
        /// Example: enc_1
        /// </summary>
        /// <example>enc_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EncoderId { get; set; }

        /// <summary>
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </summary>
        /// <example>boomerang-2023-q3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_name")]
        public string? EncoderName { get; set; }

        /// <summary>
        /// The new filter attributes of the corpus. <br/>
        /// If unset then the corpus will not have filter attributes.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_attributes")]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute>? FilterAttributes { get; set; }

        /// <summary>
        /// A custom dimension is an additional numerical field attached to a document part. You<br/>
        /// can then multiply this numerical field with a query time custom dimension of the same<br/>
        /// name. This allows boosting (or burying) document parts for arbitrary reasons.<br/>
        /// This feature is only enabled for Pro and Enterprise customers.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCorpusRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </param>
        /// <param name="description">
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus. <br/>
        /// If unset then the corpus will not have filter attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You<br/>
        /// can then multiply this numerical field with a query time custom dimension of the same<br/>
        /// name. This allows boosting (or burying) document parts for arbitrary reasons.<br/>
        /// This feature is only enabled for Pro and Enterprise customers.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCorpusRequest(
            string key,
            string? name,
            string? description,
            bool? saveHistory,
            bool? queriesAreAnswers,
            bool? documentsAreQuestions,
            string? encoderName,
            global::System.Collections.Generic.IList<global::G.FilterAttribute>? filterAttributes,
            global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? customDimensions)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name;
            this.Description = description;
            this.SaveHistory = saveHistory;
            this.QueriesAreAnswers = queriesAreAnswers;
            this.DocumentsAreQuestions = documentsAreQuestions;
            this.EncoderName = encoderName;
            this.FilterAttributes = filterAttributes;
            this.CustomDimensions = customDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCorpusRequest" /> class.
        /// </summary>
        public CreateCorpusRequest()
        {
        }
    }
}