//HintName: G.Models.AudioConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioConfig
    {
        /// <summary>
        /// Sample rate in Hz of the audio sent to the avatar.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public double SampleRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// Sample rate in Hz of the audio sent to the avatar.
        /// </param>
        public AudioConfig(
            double sampleRate)
        {
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioConfig" /> class.
        /// </summary>
        public AudioConfig()
        {
        }
    }
}