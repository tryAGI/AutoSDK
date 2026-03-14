//HintName: G.Models.CreateAgentRequestSkills.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of skills available to the agent, keyed by skill name.<br/>
    /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
    /// Example: {"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}
    /// </summary>
    public sealed partial class CreateAgentRequestSkills
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}