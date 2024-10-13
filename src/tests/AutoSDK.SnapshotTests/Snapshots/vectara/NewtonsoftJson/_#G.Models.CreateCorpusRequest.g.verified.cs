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
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries_are_answers")]
        public bool? QueriesAreAnswers { get; set; } = false;

        /// <summary>
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents_are_questions")]
        public bool? DocumentsAreQuestions { get; set; } = false;

        /// <summary>
        /// *Deprecated*: Use `encoder_name` instead.<br/>
        /// Example: enc_1
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
        /// The new filter attributes of the corpus. <br/>
        /// If unset then the corpus will not have filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_attributes")]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute>? FilterAttributes { get; set; }

        /// <summary>
        /// A custom dimension is an additional numerical field attached to a document part. You<br/>
        /// can then multiply this numerical field with a query time custom dimension of the same<br/>
        /// name. This allows boosting (or burying) document parts for arbitrary reasons.<br/>
        /// This feature is only enabled for Scale customers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateCorpusRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateCorpusRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}