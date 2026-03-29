//HintName: G.Models.PerRequestLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-request token limits
    /// </summary>
    public sealed partial class PerRequestLimits
    {
        /// <summary>
        /// Maximum prompt tokens per request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// Maximum completion tokens per request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Maximum prompt tokens per request
        /// </param>
        /// <param name="completionTokens">
        /// Maximum completion tokens per request
        /// </param>
        public PerRequestLimits(
            double promptTokens,
            double completionTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        public PerRequestLimits()
        {
        }
    }
}