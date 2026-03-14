//HintName: G.Models.AgentSkill.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A skill that provides progressively disclosed instructions to an agent; it allows the agent to access more instructions without<br/>
    /// always being within the system scope. Additionally, skills are explicitly loaded as an input event rather than normal text input event.<br/>
    /// Skills are defined at the agent level and can be filtered per step via allowed_skills.<br/>
    /// The skill key and description are shown to the LLM in the system message;<br/>
    /// the full content is sent as a user message when the skill is invoked via the invoke_skill tool.
    /// </summary>
    public sealed partial class AgentSkill
    {
        /// <summary>
        /// A brief description of what the skill does, shown to the agent in its instructions.<br/>
        /// Example: Reviews code for best practices, bugs, and security issues.
        /// </summary>
        /// <example>Reviews code for best practices, bugs, and security issues.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The full instruction content for this skill.<br/>
        /// This is NOT shown in the instructions by default; it is loaded when the skill is invoked.<br/>
        /// Example: When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...
        /// </summary>
        /// <example>When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        /// <param name="description">
        /// A brief description of what the skill does, shown to the agent in its instructions.<br/>
        /// Example: Reviews code for best practices, bugs, and security issues.
        /// </param>
        /// <param name="content">
        /// The full instruction content for this skill.<br/>
        /// This is NOT shown in the instructions by default; it is loaded when the skill is invoked.<br/>
        /// Example: When reviewing code, check for security vulnerabilities, performance issues, and adherence to best practices...
        /// </param>
        public AgentSkill(
            string description,
            string content)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkill" /> class.
        /// </summary>
        public AgentSkill()
        {
        }
    }
}