//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        MaxCountPerStep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type.MaxCountPerStep => "max_count_per_step",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "max_count_per_step" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type.MaxCountPerStep,
                _ => null,
            };
        }
    }
}