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
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string MessageType { get; set; } = "speak_metadata";

        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Model information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_info")]
        public string? ModelInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public SpeakMetadataPayload(
            string requestId,
            string? modelInfo,
            string messageType = "speak_metadata")
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