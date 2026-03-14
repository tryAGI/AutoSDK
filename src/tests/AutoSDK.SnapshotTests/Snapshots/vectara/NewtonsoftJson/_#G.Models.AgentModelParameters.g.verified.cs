//HintName: G.Models.AgentModelParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary model-specific parameters that can be passed to the model.<br/>
    /// Example: {"temperature":0.7,"max_tokens":1000,"top_p":0.9}
    /// </summary>
    public sealed partial class AgentModelParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}