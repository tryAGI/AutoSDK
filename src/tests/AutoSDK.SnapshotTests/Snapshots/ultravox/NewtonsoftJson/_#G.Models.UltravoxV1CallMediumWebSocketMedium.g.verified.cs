//HintName: G.Models.UltravoxV1CallMediumWebSocketMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for a WebSocket call.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumWebSocketMedium
    {
        /// <summary>
        /// The sample rate for input (user) audio. Required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputSampleRate")]
        public int? InputSampleRate { get; set; }

        /// <summary>
        /// The desired sample rate for output (agent) audio. If unset, defaults to the input_sample_rate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputSampleRate")]
        public int? OutputSampleRate { get; set; }

        /// <summary>
        /// The size of the client-side audio buffer in milliseconds. Smaller buffers allow for faster<br/>
        ///  interruptions but may cause audio underflow if network latency fluctuates too greatly. For<br/>
        ///  the best of both worlds, set this to some large value (e.g. 30000) and implement support for<br/>
        ///  playback_clear_buffer messages. Defaults to 60.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientBufferSizeMs")]
        public int? ClientBufferSizeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebSocketMedium" /> class.
        /// </summary>
        /// <param name="inputSampleRate">
        /// The sample rate for input (user) audio. Required.
        /// </param>
        /// <param name="outputSampleRate">
        /// The desired sample rate for output (agent) audio. If unset, defaults to the input_sample_rate.
        /// </param>
        /// <param name="clientBufferSizeMs">
        /// The size of the client-side audio buffer in milliseconds. Smaller buffers allow for faster<br/>
        ///  interruptions but may cause audio underflow if network latency fluctuates too greatly. For<br/>
        ///  the best of both worlds, set this to some large value (e.g. 30000) and implement support for<br/>
        ///  playback_clear_buffer messages. Defaults to 60.
        /// </param>
        public UltravoxV1CallMediumWebSocketMedium(
            int? inputSampleRate,
            int? outputSampleRate,
            int? clientBufferSizeMs)
        {
            this.InputSampleRate = inputSampleRate;
            this.OutputSampleRate = outputSampleRate;
            this.ClientBufferSizeMs = clientBufferSizeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebSocketMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumWebSocketMedium()
        {
        }
    }
}