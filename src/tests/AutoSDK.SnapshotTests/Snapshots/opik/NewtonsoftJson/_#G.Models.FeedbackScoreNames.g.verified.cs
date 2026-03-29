//HintName: G.Models.FeedbackScoreNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackScoreNames
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.IList<global::G.ScoreName>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreNames" /> class.
        /// </summary>
        /// <param name="scores"></param>
        public FeedbackScoreNames(
            global::System.Collections.Generic.IList<global::G.ScoreName>? scores)
        {
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreNames" /> class.
        /// </summary>
        public FeedbackScoreNames()
        {
        }
    }
}