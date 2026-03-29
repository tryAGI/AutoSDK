//HintName: G.Models.TurnTokenDataOutputTokenLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logprobs from SGLang: [[logprob, token_id, top_logprob_or_null], ...]. Only present for assistant turns.
    /// </summary>
    public sealed partial class TurnTokenDataOutputTokenLogprobs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}