//HintName: G.Models.TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOptimizeStreamingLatency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
    /// 0 - default mode (no latency optimizations)<br/>
    /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
    /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
    /// 3 - max latency optimizations<br/>
    /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
    /// Defaults to None.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostOptimizeStreamingLatency
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}