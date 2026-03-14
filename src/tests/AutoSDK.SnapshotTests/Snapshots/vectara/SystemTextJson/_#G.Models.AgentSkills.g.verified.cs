//HintName: G.Models.AgentSkills.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A map of skills available to the agent, keyed by skill name.<br/>
    /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
    /// The skill list (name + description) is shown in the system message; content is loaded on invocation.<br/>
    /// Example: {"code_review":{"description":"Reviews code for best practices and security issues.","content":"When reviewing code, focus on..."}}
    /// </summary>
    public sealed partial class AgentSkills
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}