//HintName: G.Models.InboundNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InboundNumber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public int? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_data")]
        public global::System.Collections.Generic.IList<object>? DynamicData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruption_threshold")]
        public int? InterruptionThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_sentence")]
        public string? FirstSentence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_phone_number")]
        public string? TransferPhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_track")]
        public string? BackgroundTrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_number")]
        public string? FallbackNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundNumber" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="prompt"></param>
        /// <param name="webhook"></param>
        /// <param name="voiceId"></param>
        /// <param name="dynamicData"></param>
        /// <param name="interruptionThreshold"></param>
        /// <param name="firstSentence"></param>
        /// <param name="transferPhoneNumber"></param>
        /// <param name="record"></param>
        /// <param name="maxDuration"></param>
        /// <param name="backgroundTrack"></param>
        /// <param name="pathwayId"></param>
        /// <param name="fallbackNumber"></param>
        public InboundNumber(
            global::System.DateTime? createdAt,
            string? phoneNumber,
            string? prompt,
            string? webhook,
            int? voiceId,
            global::System.Collections.Generic.IList<object>? dynamicData,
            int? interruptionThreshold,
            string? firstSentence,
            string? transferPhoneNumber,
            bool? record,
            int? maxDuration,
            string? backgroundTrack,
            string? pathwayId,
            string? fallbackNumber)
        {
            this.CreatedAt = createdAt;
            this.PhoneNumber = phoneNumber;
            this.Prompt = prompt;
            this.Webhook = webhook;
            this.VoiceId = voiceId;
            this.DynamicData = dynamicData;
            this.InterruptionThreshold = interruptionThreshold;
            this.FirstSentence = firstSentence;
            this.TransferPhoneNumber = transferPhoneNumber;
            this.Record = record;
            this.MaxDuration = maxDuration;
            this.BackgroundTrack = backgroundTrack;
            this.PathwayId = pathwayId;
            this.FallbackNumber = fallbackNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundNumber" /> class.
        /// </summary>
        public InboundNumber()
        {
        }
    }
}