//HintName: G.Models.FeedbackScoreBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackScoreBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreBatchItem> Scores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreBatch" /> class.
        /// </summary>
        /// <param name="scores"></param>
        public FeedbackScoreBatch(
            global::System.Collections.Generic.IList<global::G.FeedbackScoreBatchItem> scores)
        {
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackScoreBatch" /> class.
        /// </summary>
        public FeedbackScoreBatch()
        {
        }
    }
}