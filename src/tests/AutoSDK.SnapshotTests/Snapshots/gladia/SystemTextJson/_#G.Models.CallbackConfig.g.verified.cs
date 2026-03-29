//HintName: G.Models.CallbackConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackConfig
    {
        /// <summary>
        /// URL on which we will do a `POST` request with configured messages<br/>
        /// Example: https://callback.example
        /// </summary>
        /// <example>https://callback.example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// If true, partial transcript will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_partial_transcripts")]
        public bool? ReceivePartialTranscripts { get; set; }

        /// <summary>
        /// If true, final transcript will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_final_transcripts")]
        public bool? ReceiveFinalTranscripts { get; set; }

        /// <summary>
        /// If true, begin and end speech events will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_speech_events")]
        public bool? ReceiveSpeechEvents { get; set; }

        /// <summary>
        /// If true, pre-processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_pre_processing_events")]
        public bool? ReceivePreProcessingEvents { get; set; }

        /// <summary>
        /// If true, realtime processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_realtime_processing_events")]
        public bool? ReceiveRealtimeProcessingEvents { get; set; }

        /// <summary>
        /// If true, post-processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_post_processing_events")]
        public bool? ReceivePostProcessingEvents { get; set; }

        /// <summary>
        /// If true, acknowledgments will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_acknowledgments")]
        public bool? ReceiveAcknowledgments { get; set; }

        /// <summary>
        /// If true, errors will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_errors")]
        public bool? ReceiveErrors { get; set; }

        /// <summary>
        /// If true, lifecycle events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receive_lifecycle_events")]
        public bool? ReceiveLifecycleEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// URL on which we will do a `POST` request with configured messages<br/>
        /// Example: https://callback.example
        /// </param>
        /// <param name="receivePartialTranscripts">
        /// If true, partial transcript will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="receiveFinalTranscripts">
        /// If true, final transcript will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveSpeechEvents">
        /// If true, begin and end speech events will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="receivePreProcessingEvents">
        /// If true, pre-processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveRealtimeProcessingEvents">
        /// If true, realtime processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receivePostProcessingEvents">
        /// If true, post-processing events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveAcknowledgments">
        /// If true, acknowledgments will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="receiveErrors">
        /// If true, errors will be sent to the defined callback.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="receiveLifecycleEvents">
        /// If true, lifecycle events will be sent to the defined callback.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackConfig(
            string? url,
            bool? receivePartialTranscripts,
            bool? receiveFinalTranscripts,
            bool? receiveSpeechEvents,
            bool? receivePreProcessingEvents,
            bool? receiveRealtimeProcessingEvents,
            bool? receivePostProcessingEvents,
            bool? receiveAcknowledgments,
            bool? receiveErrors,
            bool? receiveLifecycleEvents)
        {
            this.Url = url;
            this.ReceivePartialTranscripts = receivePartialTranscripts;
            this.ReceiveFinalTranscripts = receiveFinalTranscripts;
            this.ReceiveSpeechEvents = receiveSpeechEvents;
            this.ReceivePreProcessingEvents = receivePreProcessingEvents;
            this.ReceiveRealtimeProcessingEvents = receiveRealtimeProcessingEvents;
            this.ReceivePostProcessingEvents = receivePostProcessingEvents;
            this.ReceiveAcknowledgments = receiveAcknowledgments;
            this.ReceiveErrors = receiveErrors;
            this.ReceiveLifecycleEvents = receiveLifecycleEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfig" /> class.
        /// </summary>
        public CallbackConfig()
        {
        }
    }
}