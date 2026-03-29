//HintName: G.Models.FeedbackRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rating", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Rating { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequestRequest" /> class.
        /// </summary>
        /// <param name="rating"></param>
        public FeedbackRequestRequest(
            bool rating)
        {
            this.Rating = rating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackRequestRequest" /> class.
        /// </summary>
        public FeedbackRequestRequest()
        {
        }
    }
}