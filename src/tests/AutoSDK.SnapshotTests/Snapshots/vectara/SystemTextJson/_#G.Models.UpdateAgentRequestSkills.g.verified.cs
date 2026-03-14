//HintName: G.Models.UpdateAgentRequestSkills.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of skills available to the agent. Set to null to clear all skills.<br/>
    /// Individual map values set to null will delete that skill.
    /// </summary>
    public sealed partial class UpdateAgentRequestSkills
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}