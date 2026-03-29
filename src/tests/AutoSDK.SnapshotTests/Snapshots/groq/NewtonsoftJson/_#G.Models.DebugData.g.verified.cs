//HintName: G.Models.DebugData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Debug information including input and output token IDs and strings. Only present when debug=true in the request.
    /// </summary>
    public sealed partial class DebugData
    {
        /// <summary>
        /// Token IDs for the input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_token_ids")]
        public global::System.Collections.Generic.IList<int>? InputTokenIds { get; set; }

        /// <summary>
        /// Token strings for the input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public global::System.Collections.Generic.IList<string>? InputTokens { get; set; }

        /// <summary>
        /// Token IDs for the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_token_ids")]
        public global::System.Collections.Generic.IList<int>? OutputTokenIds { get; set; }

        /// <summary>
        /// Token strings for the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public global::System.Collections.Generic.IList<string>? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugData" /> class.
        /// </summary>
        /// <param name="inputTokenIds">
        /// Token IDs for the input.
        /// </param>
        /// <param name="inputTokens">
        /// Token strings for the input.
        /// </param>
        /// <param name="outputTokenIds">
        /// Token IDs for the output.
        /// </param>
        /// <param name="outputTokens">
        /// Token strings for the output.
        /// </param>
        public DebugData(
            global::System.Collections.Generic.IList<int>? inputTokenIds,
            global::System.Collections.Generic.IList<string>? inputTokens,
            global::System.Collections.Generic.IList<int>? outputTokenIds,
            global::System.Collections.Generic.IList<string>? outputTokens)
        {
            this.InputTokenIds = inputTokenIds;
            this.InputTokens = inputTokens;
            this.OutputTokenIds = outputTokenIds;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugData" /> class.
        /// </summary>
        public DebugData()
        {
        }
    }
}