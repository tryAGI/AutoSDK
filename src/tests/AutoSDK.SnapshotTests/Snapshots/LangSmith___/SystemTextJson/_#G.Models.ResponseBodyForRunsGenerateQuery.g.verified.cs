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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> FeedbackUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBodyForRunsGenerateQuery" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="feedbackUrls"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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