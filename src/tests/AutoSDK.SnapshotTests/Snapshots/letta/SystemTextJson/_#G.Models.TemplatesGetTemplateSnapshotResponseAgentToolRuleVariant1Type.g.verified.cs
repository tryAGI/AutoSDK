//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ConstrainChildTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type.ConstrainChildTools => "constrain_child_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "constrain_child_tools" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type.ConstrainChildTools,
                _ => null,
            };
        }
    }
}