//HintName: G.Models.PredictionOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Override flow configuration and pass variables at runtime<br/>
    /// Example: {"sessionId":"user-session-123","temperature":0.7,"maxTokens":500,"vars":{"user_name":"Alice"}}
    /// </summary>
    public sealed partial class PredictionOverrideConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}