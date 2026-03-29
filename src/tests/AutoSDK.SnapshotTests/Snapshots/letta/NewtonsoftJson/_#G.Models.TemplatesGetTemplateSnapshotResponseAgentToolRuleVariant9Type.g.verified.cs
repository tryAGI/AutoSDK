//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_approval")]
        RequiresApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type.RequiresApproval => "requires_approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "requires_approval" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type.RequiresApproval,
                _ => null,
            };
        }
    }
}