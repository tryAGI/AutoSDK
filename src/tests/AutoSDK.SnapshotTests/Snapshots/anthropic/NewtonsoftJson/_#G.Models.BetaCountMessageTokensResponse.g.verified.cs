//HintName: G.Models.BetaCountMessageTokensResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCountMessageTokensResponse
    {
        /// <summary>
        /// The total number of tokens across the provided list of messages, system prompt, and tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCountMessageTokensResponse" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The total number of tokens across the provided list of messages, system prompt, and tools.
        /// </param>
        public BetaCountMessageTokensResponse(
            int inputTokens)
        {
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCountMessageTokensResponse" /> class.
        /// </summary>
        public BetaCountMessageTokensResponse()
        {
        }
    }
}