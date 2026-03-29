//HintName: G.Models.BaseMessagesResultUsageServerToolUse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultUsageServerToolUse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WebSearchRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_fetch_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WebFetchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageServerToolUse" /> class.
        /// </summary>
        /// <param name="webSearchRequests"></param>
        /// <param name="webFetchRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultUsageServerToolUse(
            double webSearchRequests,
            double webFetchRequests)
        {
            this.WebSearchRequests = webSearchRequests;
            this.WebFetchRequests = webFetchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageServerToolUse" /> class.
        /// </summary>
        public BaseMessagesResultUsageServerToolUse()
        {
        }
    }
}