//HintName: G.Models.MessageObjectIncompleteDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// On an incomplete message, details about why the message is incomplete.
    /// </summary>
    public sealed partial class MessageObjectIncompleteDetails
    {
        /// <summary>
        /// The reason the message is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MessageObjectIncompleteDetailsReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageObjectIncompleteDetailsReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}