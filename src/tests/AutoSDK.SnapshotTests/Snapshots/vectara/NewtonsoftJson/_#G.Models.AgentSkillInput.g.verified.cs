//HintName: G.Models.AgentSkillInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An input that invokes a skill by name.
    /// </summary>
    public sealed partial class AgentSkillInput
    {
        /// <summary>
        /// The type of input.<br/>
        /// Default Value: skill<br/>
        /// Example: skill
        /// </summary>
        /// <default>"skill"</default>
        /// <example>skill</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The name (key) of the skill to invoke.<br/>
        /// Example: code_review
        /// </summary>
        /// <example>code_review</example>
        [global::Newtonsoft.Json.JsonProperty("skill_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SkillName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input.<br/>
        /// Default Value: skill<br/>
        /// Example: skill
        /// </param>
        /// <param name="skillName">
        /// The name (key) of the skill to invoke.<br/>
        /// Example: code_review
        /// </param>
        public AgentSkillInput(
            string type,
            string skillName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSkillInput" /> class.
        /// </summary>
        public AgentSkillInput()
        {
        }
    }
}