//HintName: G.Models.ListPromptsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPromptsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.PromptSummary>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="total"></param>
        public ListPromptsResponse(
            global::System.Collections.Generic.IList<global::G.PromptSummary>? data,
            int? total)
        {
            this.Data = data;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPromptsResponse" /> class.
        /// </summary>
        public ListPromptsResponse()
        {
        }
    }
}