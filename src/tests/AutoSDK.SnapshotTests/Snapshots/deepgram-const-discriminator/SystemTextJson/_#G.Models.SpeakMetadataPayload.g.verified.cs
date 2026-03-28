//HintName: G.Models.SpeakMetadataPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for the speak session.
    /// </summary>
    public sealed partial class SpeakMetadataPayload
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"speak_metadata"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string MessageType { get; set; } = "speak_metadata";

        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Model information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        public string? ModelInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakMetadataPayload" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier.
        /// </param>
        /// <param name="modelInfo">
        /// Model information.
        /// </param>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakMetadataPayload(
            string requestId,
            string? modelInfo,
            string messageType = "speak_metadata")
        {
            this.MessageType = messageType;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ModelInfo = modelInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakMetadataPayload" /> class.
        /// </summary>
        public SpeakMetadataPayload()
        {
        }
    }
}