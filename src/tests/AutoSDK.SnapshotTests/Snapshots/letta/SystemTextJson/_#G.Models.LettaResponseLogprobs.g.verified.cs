//HintName: G.Models.LettaResponseLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Log probabilities of the output tokens from the last LLM call. Only present if return_logprobs was enabled.
    /// </summary>
    public sealed partial class LettaResponseLogprobs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}