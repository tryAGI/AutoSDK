//HintName: G.Models.RequestBodyForRunsGenerateQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestBodyForRunsGenerateQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_keys")]
        public global::System.Collections.Generic.IList<global::G.RunsGenerateQueryFeedbackKeys>? FeedbackKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyForRunsGenerateQuery" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="feedbackKeys"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RequestBodyForRunsGenerateQuery(
            string query,
            global::System.Collections.Generic.IList<global::G.RunsGenerateQueryFeedbackKeys>? feedbackKeys)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.FeedbackKeys = feedbackKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyForRunsGenerateQuery" /> class.
        /// </summary>
        public RequestBodyForRunsGenerateQuery()
        {
        }
    }
}