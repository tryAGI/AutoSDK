//HintName: G.Models.UsageTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTokens
    {
        /// <summary>
        /// The number of tokens used as input to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public double InputTokens { get; set; }

        /// <summary>
        /// The number of tokens produced by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public double OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}