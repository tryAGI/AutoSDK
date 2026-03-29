//HintName: G.Models.AudioChunkAckData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioChunkAckData
    {
        /// <summary>
        /// Range in bytes length of the audio chunk (relative to the whole session)<br/>
        /// Example: [1024, 2048]
        /// </summary>
        /// <example>[1024, 2048]</example>
        [global::Newtonsoft.Json.JsonProperty("byte_range", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<long> ByteRange { get; set; } = default!;

        /// <summary>
        /// Range in seconds of the audio chunk (relative to the whole session)<br/>
        /// Example: [0.8F, 0.9F]
        /// </summary>
        /// <example>[0.8F, 0.9F]</example>
        [global::Newtonsoft.Json.JsonProperty("time_range", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> TimeRange { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkAckData" /> class.
        /// </summary>
        /// <param name="byteRange">
        /// Range in bytes length of the audio chunk (relative to the whole session)<br/>
        /// Example: [1024, 2048]
        /// </param>
        /// <param name="timeRange">
        /// Range in seconds of the audio chunk (relative to the whole session)<br/>
        /// Example: [0.8F, 0.9F]
        /// </param>
        public AudioChunkAckData(
            global::System.Collections.Generic.IList<long> byteRange,
            global::System.Collections.Generic.IList<double> timeRange)
        {
            this.ByteRange = byteRange ?? throw new global::System.ArgumentNullException(nameof(byteRange));
            this.TimeRange = timeRange ?? throw new global::System.ArgumentNullException(nameof(timeRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkAckData" /> class.
        /// </summary>
        public AudioChunkAckData()
        {
        }
    }
}