//HintName: G.Models.ListLLMsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListLLMsResponse
    {
        /// <summary>
        /// List of LLMs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llms")]
        public global::System.Collections.Generic.IList<global::G.LLM>? Llms { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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