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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeakMetadataPayloadMessageTypeJsonConverter))]
        public global::G.SpeakMetadataPayloadMessageType MessageType { get; set; }

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
        /// <param name="messageType"></param>
        /// <param name="requestId">
        /// Unique request identifier.
        /// </param>
        /// <param name="modelInfo">
        /// Model information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakMetadataPayload(
            string requestId,
            global::G.SpeakMetadataPayloadMessageType messageType,
            string? modelInfo)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.MessageType = messageType;
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