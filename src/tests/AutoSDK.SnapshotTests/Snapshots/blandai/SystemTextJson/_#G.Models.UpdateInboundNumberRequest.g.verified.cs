//HintName: G.Models.UpdateInboundNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateInboundNumberRequest
    {
        /// <summary>
        /// Instructions and context for the agent during inbound calls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Voice ID or preset name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Opening phrase for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_sentence")]
        public string? FirstSentence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateInboundNumberRequestModelJsonConverter))]
        public global::G.UpdateInboundNumberRequestModel? Model { get; set; }

        /// <summary>
        /// Language code (default en-US)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Default Value: America/Los_Angeles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_track")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateInboundNumberRequestBackgroundTrackJsonConverter))]
        public global::G.UpdateInboundNumberRequestBackgroundTrack? BackgroundTrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_interruptions")]
        public bool? BlockInterruptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_threshold")]
        public int? InterruptionThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise_cancellation")]
        public bool? NoiseCancellation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_phone_number")]
        public string? TransferPhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_list")]
        public global::System.Collections.Generic.Dictionary<string, string>? TransferList { get; set; }

        /// <summary>
        /// Redirect number during maintenance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_number")]
        public string? FallbackNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_data")]
        public global::System.Collections.Generic.IList<object>? DynamicData { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration")]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record")]
        public bool? Record { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<string>? WebhookEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboundNumberRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Instructions and context for the agent during inbound calls
        /// </param>
        /// <param name="voice">
        /// Voice ID or preset name
        /// </param>
        /// <param name="firstSentence">
        /// Opening phrase for the agent
        /// </param>
        /// <param name="model"></param>
        /// <param name="language">
        /// Language code (default en-US)
        /// </param>
        /// <param name="timezone">
        /// Default Value: America/Los_Angeles
        /// </param>
        /// <param name="backgroundTrack"></param>
        /// <param name="blockInterruptions"></param>
        /// <param name="interruptionThreshold"></param>
        /// <param name="noiseCancellation"></param>
        /// <param name="transferPhoneNumber"></param>
        /// <param name="transferList"></param>
        /// <param name="fallbackNumber">
        /// Redirect number during maintenance
        /// </param>
        /// <param name="requestData"></param>
        /// <param name="dynamicData"></param>
        /// <param name="maxDuration">
        /// Default Value: 30
        /// </param>
        /// <param name="record"></param>
        /// <param name="webhook"></param>
        /// <param name="webhookEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateInboundNumberRequest(
            string prompt,
            string? voice,
            string? firstSentence,
            global::G.UpdateInboundNumberRequestModel? model,
            string? language,
            string? timezone,
            global::G.UpdateInboundNumberRequestBackgroundTrack? backgroundTrack,
            bool? blockInterruptions,
            int? interruptionThreshold,
            bool? noiseCancellation,
            string? transferPhoneNumber,
            global::System.Collections.Generic.Dictionary<string, string>? transferList,
            string? fallbackNumber,
            object? requestData,
            global::System.Collections.Generic.IList<object>? dynamicData,
            int? maxDuration,
            bool? record,
            string? webhook,
            global::System.Collections.Generic.IList<string>? webhookEvents)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Voice = voice;
            this.FirstSentence = firstSentence;
            this.Model = model;
            this.Language = language;
            this.Timezone = timezone;
            this.BackgroundTrack = backgroundTrack;
            this.BlockInterruptions = blockInterruptions;
            this.InterruptionThreshold = interruptionThreshold;
            this.NoiseCancellation = noiseCancellation;
            this.TransferPhoneNumber = transferPhoneNumber;
            this.TransferList = transferList;
            this.FallbackNumber = fallbackNumber;
            this.RequestData = requestData;
            this.DynamicData = dynamicData;
            this.MaxDuration = maxDuration;
            this.Record = record;
            this.Webhook = webhook;
            this.WebhookEvents = webhookEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInboundNumberRequest" /> class.
        /// </summary>
        public UpdateInboundNumberRequest()
        {
        }
    }
}