//HintName: G.Models.LLMConfigEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The effort level for Anthropic models that support it (Opus 4.5, Opus 4.6). Controls token spending and thinking behavior. Not setting this gives similar performance to 'high'.
    /// </summary>
    public sealed partial class LLMConfigEffort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}