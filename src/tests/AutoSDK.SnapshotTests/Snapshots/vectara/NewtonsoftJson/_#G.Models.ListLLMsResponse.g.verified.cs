//HintName: G.Models.ListLLMsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of Large Language Models available for generative AI capabilities.
    /// </summary>
    public sealed partial class ListLLMsResponse
    {
        /// <summary>
        /// List of LLMs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llms")]
        public global::System.Collections.Generic.IList<global::G.LLM>? Llms { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLLMsResponse" /> class.
        /// </summary>
        /// <param name="llms">
        /// List of LLMs.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        public ListLLMsResponse(
            global::System.Collections.Generic.IList<global::G.LLM>? llms,
            global::G.ListMetadata? metadata)
        {
            this.Llms = llms;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLLMsResponse" /> class.
        /// </summary>
        public ListLLMsResponse()
        {
        }
    }
}