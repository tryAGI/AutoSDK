//HintName: G.Models.LettaStreamingRequestTopLogprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
    /// </summary>
    public sealed partial class LettaStreamingRequestTopLogprobs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}