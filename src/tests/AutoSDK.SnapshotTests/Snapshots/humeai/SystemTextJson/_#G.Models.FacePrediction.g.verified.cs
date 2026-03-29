//HintName: G.Models.FacePrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacePrediction
    {
        /// <summary>
        /// Frame number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        public int? Frame { get; set; }

        /// <summary>
        /// Time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::G.BoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// Detection probability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prob")]
        public double? Prob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<global::G.EmotionScore>? Emotions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facs")]
        public global::System.Collections.Generic.IList<global::G.FacsScore>? Facs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptions")]
        public global::System.Collections.Generic.IList<global::G.DescriptionsScore>? Descriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacePrediction" /> class.
        /// </summary>
        /// <param name="frame">
        /// Frame number
        /// </param>
        /// <param name="time">
        /// Time in seconds
        /// </param>
        /// <param name="boundingBox"></param>
        /// <param name="prob">
        /// Detection probability
        /// </param>
        /// <param name="emotions"></param>
        /// <param name="facs"></param>
        /// <param name="descriptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacePrediction(
            int? frame,
            double? time,
            global::G.BoundingBox? boundingBox,
            double? prob,
            global::System.Collections.Generic.IList<global::G.EmotionScore>? emotions,
            global::System.Collections.Generic.IList<global::G.FacsScore>? facs,
            global::System.Collections.Generic.IList<global::G.DescriptionsScore>? descriptions)
        {
            this.Frame = frame;
            this.Time = time;
            this.BoundingBox = boundingBox;
            this.Prob = prob;
            this.Emotions = emotions;
            this.Facs = facs;
            this.Descriptions = descriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacePrediction" /> class.
        /// </summary>
        public FacePrediction()
        {
        }
    }
}