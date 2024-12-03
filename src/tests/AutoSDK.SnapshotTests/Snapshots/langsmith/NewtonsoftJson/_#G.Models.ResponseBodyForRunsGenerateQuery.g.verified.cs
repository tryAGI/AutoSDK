//HintName: G.Models.ResponseBodyForRunsGenerateQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseBodyForRunsGenerateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> FeedbackUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBodyForRunsGenerateQuery" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="feedbackUrls"></param>
        public ResponseBodyForRunsGenerateQuery(
            string filter,
            global::System.Collections.Generic.Dictionary<string, string> feedbackUrls)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.FeedbackUrls = feedbackUrls ?? throw new global::System.ArgumentNullException(nameof(feedbackUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBodyForRunsGenerateQuery" /> class.
        /// </summary>
        public ResponseBodyForRunsGenerateQuery()
        {
        }
    }
}