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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "skill";

        /// <summary>
        /// The name (key) of the skill to invoke.<br/>
        /// Example: code_review
        /// </summary>
        /// <example>code_review</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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