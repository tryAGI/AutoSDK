//HintName: G.Models.FeedbackItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorInput Example { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public float Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackItem" /> class.
        /// </summary>
        /// <param name="example"></param>
        /// <param name="score"></param>
        public FeedbackItem(
            global::G.VectorInput example,
            float score)
        {
            this.Example = example;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackItem" /> class.
        /// </summary>
        public FeedbackItem()
        {
        }
    }
}