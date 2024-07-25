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
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_keys")]
        public global::System.Collections.Generic.IList<global::G.RunsGenerateQueryFeedbackKeys>? FeedbackKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}