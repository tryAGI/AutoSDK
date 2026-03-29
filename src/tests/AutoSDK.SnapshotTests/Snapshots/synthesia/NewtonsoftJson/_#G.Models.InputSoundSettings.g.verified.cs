//HintName: G.Models.InputSoundSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputSoundSettings
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundtrackVolume")]
        public double? SoundtrackVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSoundSettings" /> class.
        /// </summary>
        /// <param name="soundtrackVolume">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public InputSoundSettings(
            double? soundtrackVolume)
        {
            this.SoundtrackVolume = soundtrackVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSoundSettings" /> class.
        /// </summary>
        public InputSoundSettings()
        {
        }
    }
}