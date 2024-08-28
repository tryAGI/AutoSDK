//HintName: G.Models.ChatStreamStartEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamStartEventVariant2
    {
        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}