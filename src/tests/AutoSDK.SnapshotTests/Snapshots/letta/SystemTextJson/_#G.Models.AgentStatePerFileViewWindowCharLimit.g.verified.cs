//HintName: G.Models.AgentStatePerFileViewWindowCharLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
    /// </summary>
    public sealed partial class AgentStatePerFileViewWindowCharLimit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}