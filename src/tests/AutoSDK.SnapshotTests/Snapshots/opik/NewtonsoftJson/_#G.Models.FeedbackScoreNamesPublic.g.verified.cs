//HintName: G.Models.FeedbackScoreNamesPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackScoreNamesPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.IList<global::G.ScoreNamePublic>? Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreNamesPublic" /> class.
        /// </summary>
        /// <param name="scores"></param>
        public FeedbackScoreNamesPublic(
            global::System.Collections.Generic.IList<global::G.ScoreNamePublic>? scores)
        {
            this.Scores = scores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreNamesPublic" /> class.
        /// </summary>
        public FeedbackScoreNamesPublic()
        {
        }
    }
}