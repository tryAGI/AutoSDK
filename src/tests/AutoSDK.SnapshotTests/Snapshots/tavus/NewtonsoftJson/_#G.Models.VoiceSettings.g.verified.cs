//HintName: G.Models.VoiceSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VoiceSettingsSpeedJsonConverter))]
        public global::G.VoiceSettingsSpeed? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion")]
        public global::System.Collections.Generic.IList<string>? Emotion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="emotion"></param>
        public VoiceSettings(
            global::G.VoiceSettingsSpeed? speed,
            global::System.Collections.Generic.IList<string>? emotion)
        {
            this.Speed = speed;
            this.Emotion = emotion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettings" /> class.
        /// </summary>
        public VoiceSettings()
        {
        }
    }
}