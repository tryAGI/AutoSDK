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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </summary>
        /// <example>my-corpus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Name for the corpus. This value defaults to the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Corpus description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Specifies whether the corpus is enabled or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates that this corpus does not store documents and stores chats instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history_corpus")]
        public bool? ChatHistoryCorpus { get; set; }

        /// <summary>
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// This swaps the semantics of the encoder used at query time.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries_are_answers")]
        public bool? QueriesAreAnswers { get; set; }

        /// <summary>
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// This swaps the semantics of the encoder used at indexing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents_are_questions")]
        public bool? DocumentsAreQuestions { get; set; }

        /// <summary>
        /// The encoder used by the corpus.<br/>
        /// *Deprecated*: use `encoder_name` instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EncoderId { get; set; }

        /// <summary>
        /// The encoder used by the corpus.<br/>
        /// Example: boomerang
        /// </summary>
        /// <example>boomerang</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoder_name")]
        public string? EncoderName { get; set; }

        /// <summary>
        /// The new filter attributes of the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_attributes")]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute>? FilterAttributes { get; set; }

        /// <summary>
        /// The custom dimensions of all document parts inside the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        public global::G.CorpusLimits? Limits { get; set; }

        /// <summary>
        /// Indicates when the corpus was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Corpus" /> class.
        /// </summary>
        /// <param name="id">
        /// Vectara ID of the corpus.
        /// </param>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// Name for the corpus. This value defaults to the key.
        /// </param>
        /// <param name="description">
        /// Corpus description.
        /// </param>
        /// <param name="enabled">
        /// Specifies whether the corpus is enabled or not.
        /// </param>
        /// <param name="chatHistoryCorpus">
        /// Indicates that this corpus does not store documents and stores chats instead.
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// This swaps the semantics of the encoder used at query time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// This swaps the semantics of the encoder used at indexing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus.<br/>
        /// Example: boomerang
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus.
        /// </param>
        /// <param name="customDimensions">
        /// The custom dimensions of all document parts inside the corpus.
        /// </param>
        /// <param name="limits"></param>
        /// <param name="createdAt">
        /// Indicates when the corpus was created.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Corpus(
            string? id,
            string? key,
            string? name,
            string? description,
            bool? enabled,
            bool? chatHistoryCorpus,
            bool? queriesAreAnswers,
            bool? documentsAreQuestions,
            string? encoderName,
            global::System.Collections.Generic.IList<global::G.FilterAttribute>? filterAttributes,
            global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? customDimensions,
            global::G.CorpusLimits? limits,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
            this.ChatHistoryCorpus = chatHistoryCorpus;
            this.QueriesAreAnswers = queriesAreAnswers;
            this.DocumentsAreQuestions = documentsAreQuestions;
            this.EncoderName = encoderName;
            this.FilterAttributes = filterAttributes;
            this.CustomDimensions = customDimensions;
            this.Limits = limits;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Corpus" /> class.
        /// </summary>
        public Corpus()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Corpus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Corpus),
                jsonSerializerContext) as global::G.Corpus;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Corpus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Corpus>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Corpus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Corpus),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Corpus;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Corpus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Corpus?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}