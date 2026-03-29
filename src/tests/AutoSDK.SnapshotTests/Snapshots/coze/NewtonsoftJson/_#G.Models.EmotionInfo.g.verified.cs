//HintName: G.Models.EmotionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmotionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotion_scale_interval")]
        public global::G.Interval? EmotionScaleInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionInfo" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="emotion"></param>
        /// <param name="emotionScaleInterval"></param>
        public EmotionInfo(
            string? displayName,
            string? emotion,
            global::G.Interval? emotionScaleInterval)
        {
            this.DisplayName = displayName;
            this.Emotion = emotion;
            this.EmotionScaleInterval = emotionScaleInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmotionInfo" /> class.
        /// </summary>
        public EmotionInfo()
        {
        }
    }
}