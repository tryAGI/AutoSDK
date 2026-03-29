//HintName: G.Models.MessagesConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesConfig
    {
        /// <summary>
        /// If true, partial transcript will be sent to websocket.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_partial_transcripts")]
        public bool? ReceivePartialTranscripts { get; set; }

        /// <summary>
        /// If true, final transcript will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_final_transcripts")]
        public bool? ReceiveFinalTranscripts { get; set; }

        /// <summary>
        /// If true, begin and end speech events will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_speech_events")]
        public bool? ReceiveSpeechEvents { get; set; }

        /// <summary>
        /// If true, pre-processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_pre_processing_events")]
        public bool? ReceivePreProcessingEvents { get; set; }

        /// <summary>
        /// If true, realtime processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_realtime_processing_events")]
        public bool? ReceiveRealtimeProcessingEvents { get; set; }

        /// <summary>
        /// If true, post-processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_post_processing_events")]
        public bool? ReceivePostProcessingEvents { get; set; }

        /// <summary>
        /// If true, acknowledgments will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_acknowledgments")]
        public bool? ReceiveAcknowledgments { get; set; }

        /// <summary>
        /// If true, errors will be sent to websocket.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_errors")]
        public bool? ReceiveErrors { get; set; }

        /// <summary>
        /// If true, lifecycle events will be sent to websocket.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("receive_lifecycle_events")]
        public bool? ReceiveLifecycleEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesConfig" /> class.
        /// </summary>
        /// <param name="receivePartialTranscripts">
        /// If true, partial transcript will be sent to websocket.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="receiveFinalTranscripts">
        /// If true, final transcript will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveSpeechEvents">
        /// If true, begin and end speech events will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receivePreProcessingEvents">
        /// If true, pre-processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveRealtimeProcessingEvents">
        /// If true, realtime processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receivePostProcessingEvents">
        /// If true, post-processing events will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveAcknowledgments">
        /// If true, acknowledgments will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveErrors">
        /// If true, errors will be sent to websocket.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="receiveLifecycleEvents">
        /// If true, lifecycle events will be sent to websocket.<br/>
        /// Default Value: false
        /// </param>
        public MessagesConfig(
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
        /// Initializes a new instance of the <see cref="MessagesConfig" /> class.
        /// </summary>
        public MessagesConfig()
        {
        }
    }
}