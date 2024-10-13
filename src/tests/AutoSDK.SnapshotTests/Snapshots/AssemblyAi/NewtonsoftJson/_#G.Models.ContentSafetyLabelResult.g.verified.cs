//HintName: G.Models.ContentSafetyLabelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentSafetyLabelResult
    {
        /// <summary>
        /// The transcript of the section flagged by the Content Moderation model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// An array of safety labels, one per sensitive topic that was detected in the section
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentSafetyLabel> Labels { get; set; } = default!;

        /// <summary>
        /// The sentence index at which the section begins
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_idx_start", Required = global::Newtonsoft.Json.Required.Always)]
        public int SentencesIdxStart { get; set; } = default!;

        /// <summary>
        /// The sentence index at which the section ends
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_idx_end", Required = global::Newtonsoft.Json.Required.Always)]
        public int SentencesIdxEnd { get; set; } = default!;

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Timestamp Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ContentSafetyLabelResult? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ContentSafetyLabelResult>(
                json,
                jsonSerializerOptions);
        }

    }
}