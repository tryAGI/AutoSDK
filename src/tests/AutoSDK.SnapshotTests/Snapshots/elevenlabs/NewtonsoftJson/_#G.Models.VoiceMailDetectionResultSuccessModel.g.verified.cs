//HintName: G.Models.VoiceMailDetectionResultSuccessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceMailDetectionResultSuccessModel
    {
        /// <summary>
        /// Default Value: voicemail_detection_success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voicemail_message")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMailDetectionResultSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: voicemail_detection_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="voicemailMessage"></param>
        /// <param name="reason"></param>
        public VoiceMailDetectionResultSuccessModel(
            string? resultType,
            string? status,
            string? voicemailMessage,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.VoicemailMessage = voicemailMessage;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMailDetectionResultSuccessModel" /> class.
        /// </summary>
        public VoiceMailDetectionResultSuccessModel()
        {
        }
    }
}