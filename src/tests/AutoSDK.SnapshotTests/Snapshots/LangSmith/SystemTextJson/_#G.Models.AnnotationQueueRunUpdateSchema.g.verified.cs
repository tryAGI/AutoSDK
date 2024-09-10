//HintName: G.Models.AnnotationQueueRunUpdateSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueRunUpdateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::System.DateTime?, object>? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::G.AnyOf<global::System.DateTime?, object>? AddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}