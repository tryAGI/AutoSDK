//HintName: G.Models.SkillLoadEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkillLoadEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: skill_load
        /// </summary>
        /// <default>"skill_load"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "skill_load";

        /// <summary>
        /// The name of the skill that was loaded.<br/>
        /// Example: code_review
        /// </summary>
        /// <example>code_review</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillName { get; set; }

        /// <summary>
        /// The skill content that was loaded.<br/>
        /// Example: You are a code reviewer. Review the code for bugs and security issues.
        /// </summary>
        /// <example>You are a code reviewer. Review the code for bugs and security issues.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillLoadEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: skill_load
        /// </param>
        /// <param name="skillName">
        /// The name of the skill that was loaded.<br/>
        /// Example: code_review
        /// </param>
        /// <param name="content">
        /// The skill content that was loaded.<br/>
        /// Example: You are a code reviewer. Review the code for bugs and security issues.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkillLoadEventVariant2(
            string type,
            string skillName,
            string content)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SkillName = skillName ?? throw new global::System.ArgumentNullException(nameof(skillName));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillLoadEventVariant2" /> class.
        /// </summary>
        public SkillLoadEventVariant2()
        {
        }
    }
}