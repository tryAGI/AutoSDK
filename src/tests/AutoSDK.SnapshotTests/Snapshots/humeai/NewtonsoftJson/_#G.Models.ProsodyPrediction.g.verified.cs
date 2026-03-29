//HintName: G.Models.ProsodyPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProsodyPrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public global::G.TimeInterval? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyPrediction" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="emotions"></param>
        public ProsodyPrediction(
            global::G.TimeInterval? time,
            global::System.Collections.Generic.IList<global::G.EmotionScore>? emotions)
        {
            this.Time = time;
            this.Emotions = emotions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyPrediction" /> class.
        /// </summary>
        public ProsodyPrediction()
        {
        }
    }
}