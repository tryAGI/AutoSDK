//HintName: G.Models.UpdateWhatsAppAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWhatsAppAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_agent_id")]
        public string? AssignedAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_messaging")]
        public bool? EnableMessaging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_audio_message_response")]
        public bool? EnableAudioMessageResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWhatsAppAccountRequest" /> class.
        /// </summary>
        /// <param name="assignedAgentId"></param>
        /// <param name="enableMessaging"></param>
        /// <param name="enableAudioMessageResponse"></param>
        public UpdateWhatsAppAccountRequest(
            string? assignedAgentId,
            bool? enableMessaging,
            bool? enableAudioMessageResponse)
        {
            this.AssignedAgentId = assignedAgentId;
            this.EnableMessaging = enableMessaging;
            this.EnableAudioMessageResponse = enableAudioMessageResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWhatsAppAccountRequest" /> class.
        /// </summary>
        public UpdateWhatsAppAccountRequest()
        {
        }
    }
}