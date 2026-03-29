//HintName: G.Models.MessagesResultUsageServerToolUse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsageServerToolUse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_search_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double WebSearchRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_fetch_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double WebFetchRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageServerToolUse" /> class.
        /// </summary>
        /// <param name="webSearchRequests"></param>
        /// <param name="webFetchRequests"></param>
        public MessagesResultUsageServerToolUse(
            double webSearchRequests,
            double webFetchRequests)
        {
            this.WebSearchRequests = webSearchRequests;
            this.WebFetchRequests = webFetchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageServerToolUse" /> class.
        /// </summary>
        public MessagesResultUsageServerToolUse()
        {
        }
    }
}