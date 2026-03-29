//HintName: G.Models.GetLLMsTxtStatusResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLLMsTxtStatusResponseData
    {
        /// <summary>
        /// The generated LLMs.txt content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llmstxt")]
        public string? Llmstxt { get; set; }

        /// <summary>
        /// The full text content when showFullText is true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llmsfulltxt")]
        public string? Llmsfulltxt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLLMsTxtStatusResponseData" /> class.
        /// </summary>
        /// <param name="llmstxt">
        /// The generated LLMs.txt content
        /// </param>
        /// <param name="llmsfulltxt">
        /// The full text content when showFullText is true
        /// </param>
        public GetLLMsTxtStatusResponseData(
            string? llmstxt,
            string? llmsfulltxt)
        {
            this.Llmstxt = llmstxt;
            this.Llmsfulltxt = llmsfulltxt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLLMsTxtStatusResponseData" /> class.
        /// </summary>
        public GetLLMsTxtStatusResponseData()
        {
        }
    }
}