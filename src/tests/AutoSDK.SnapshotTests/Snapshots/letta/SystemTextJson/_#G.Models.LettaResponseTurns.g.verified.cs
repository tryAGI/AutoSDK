//HintName: G.Models.LettaResponseTurns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token data for all LLM generations in multi-turn agent interaction. Includes token IDs and logprobs for each assistant turn, plus tool result content. Only present if return_token_ids was enabled. Used for RL training with loss masking.
    /// </summary>
    public sealed partial class LettaResponseTurns
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}