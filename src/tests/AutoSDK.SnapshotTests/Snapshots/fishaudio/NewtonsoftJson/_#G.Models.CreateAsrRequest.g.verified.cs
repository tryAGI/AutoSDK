//HintName: G.Models.CreateAsrRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAsrRequest
    {
        /// <summary>
        /// Audio to be converted to text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Audio { get; set; } = default!;

        /// <summary>
        /// Audio to be converted to text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Audioname { get; set; } = default!;

        /// <summary>
        /// Language to be used for the speech<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Whether to return precise timestamps in the text, this will increase the latency in audio shorter than 30 seconds<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_timestamps")]
        public bool? IgnoreTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// Audio to be converted to text
        /// </param>
        /// <param name="audioname">
        /// Audio to be converted to text
        /// </param>
        /// <param name="language">
        /// Language to be used for the speech<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ignoreTimestamps">
        /// Whether to return precise timestamps in the text, this will increase the latency in audio shorter than 30 seconds<br/>
        /// Default Value: true
        /// </param>
        public CreateAsrRequest(
            byte[] audio,
            string audioname,
            string? language,
            bool? ignoreTimestamps)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Language = language;
            this.IgnoreTimestamps = ignoreTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrRequest" /> class.
        /// </summary>
        public CreateAsrRequest()
        {
        }
    }
}