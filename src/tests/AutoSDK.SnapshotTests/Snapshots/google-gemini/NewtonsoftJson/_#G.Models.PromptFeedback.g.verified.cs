//HintName: G.Models.PromptFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
    /// </summary>
    public sealed partial class PromptFeedback
    {
        /// <summary>
        /// Ratings for safety of the prompt. There is at most one rating per category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safetyRatings")]
        public global::System.Collections.Generic.IList<global::G.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase your prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blockReason")]
        public global::G.PromptFeedbackBlockReason? BlockReason { get; set; }

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
        public static global::G.PromptFeedback? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PromptFeedback>(
                json,
                jsonSerializerOptions);
        }

    }
}