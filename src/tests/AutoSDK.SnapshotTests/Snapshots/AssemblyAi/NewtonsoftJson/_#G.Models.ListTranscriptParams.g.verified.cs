//HintName: G.Models.ListTranscriptParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTranscriptParams
    {
        /// <summary>
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.TranscriptStatus? Status { get; set; }

        /// <summary>
        /// Only get transcripts created on this date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Get transcripts that were created before this transcript ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before_id")]
        public global::System.Guid? BeforeId { get; set; }

        /// <summary>
        /// Get transcripts that were created after this transcript ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_id")]
        public global::System.Guid? AfterId { get; set; }

        /// <summary>
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throttled_only")]
        public bool? ThrottledOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptParams" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum amount of transcripts to retrieve<br/>
        /// Default Value: 10L
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn">
        /// Only get transcripts created on this date
        /// </param>
        /// <param name="beforeId">
        /// Get transcripts that were created before this transcript ID
        /// </param>
        /// <param name="afterId">
        /// Get transcripts that were created after this transcript ID
        /// </param>
        /// <param name="throttledOnly">
        /// Only get throttled transcripts, overrides the status filter<br/>
        /// Default Value: false
        /// </param>
        public ListTranscriptParams(
            long? limit,
            global::G.TranscriptStatus? status,
            global::System.DateTime? createdOn,
            global::System.Guid? beforeId,
            global::System.Guid? afterId,
            bool? throttledOnly)
        {
            this.Limit = limit;
            this.Status = status;
            this.CreatedOn = createdOn;
            this.BeforeId = beforeId;
            this.AfterId = afterId;
            this.ThrottledOnly = throttledOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTranscriptParams" /> class.
        /// </summary>
        public ListTranscriptParams()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ListTranscriptParams? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListTranscriptParams>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ListTranscriptParams?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ListTranscriptParams?>(serializer.Deserialize<global::G.ListTranscriptParams>(jsonReader));
        }

    }
}